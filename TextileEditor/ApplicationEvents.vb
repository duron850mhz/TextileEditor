Imports Gecko
Imports System.IO

Namespace My
    ' 次のイベントは MyApplication に対して利用できます:
    ' Startup:アプリケーションが開始されたとき、スタートアップ フォームが作成される前に発生します。
    ' Shutdown:アプリケーション フォームがすべて閉じられた後に発生します。このイベントは、アプリケーションが異常終了したときには発生しません。
    ' UnhandledException:ハンドルされない例外がアプリケーションで発生したときに発生します。
    ' StartupNextInstance:単一インスタンス アプリケーションが起動され、それが既にアクティブであるときに発生します。 
    ' NetworkAvailabilityChanged:ネットワーク接続が接続されたとき、または切断されたときに発生します。
    Partial Friend Class MyApplication
        Protected Overrides Function OnStartup(ByVal eventArgs As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) As Boolean
            Dim ProfileDirectory As String = My.Application.Info.DirectoryPath & "\Firefox\Profile"
            If Not Directory.Exists(ProfileDirectory) Then
                Directory.CreateDirectory(ProfileDirectory)
            End If
            Xpcom.ProfileDirectory = ProfileDirectory
            Gecko.Xpcom.Initialize("Firefox")
            Return True
        End Function
    End Class
End Namespace
