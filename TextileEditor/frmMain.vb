Imports System.IO
Imports KN_Library.GNcls_Util

Public Class frmMain
    Dim LG_bSetbyProg As Boolean = False
    Dim LG_strText As String = ""
    Dim LG_strCurrentFilePath As String = ""

    Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        Me.Icon = My.Resources.icon
        Call GU_ControlMySettings(0, Me)
    End Sub

    ''' <summary>
    ''' 初期化
    ''' </summary>
    Private Sub I_Init()
        Dim strAppPath As String = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
        Dim strURL As String = Path.Combine(strAppPath, "index.html")
        LG_strText = Path.Combine(strAppPath, "default.txt")

        If (File.Exists(LG_strText) = False) Then
            File.Create(LG_strText).Close()
        End If

        LG_bSetbyProg = True

        'txt
        txtText.Text = My.Computer.FileSystem.ReadAllText(LG_strText)

        'browser
        GeckoWebBrowser1.Navigate(strURL)

        LG_bSetbyProg = False
    End Sub

    ''' <summary>
    ''' 文字修飾
    ''' </summary>
    ''' <param name="strFormat"></param>
    ''' <param name="strSample"></param>
    Private Sub I_Modify(ByVal strFormat As String, ByVal strSample As String)
        If (txtText.SelectionLength = 0) Then
            txtText.SelectedText = strFormat & strSample & strFormat
        End If
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Call GU_ControlMySettings(1, Me)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call I_Init()
    End Sub

    Private Sub txtText_TextChanged(sender As Object, e As EventArgs) Handles txtText.TextChanged
        If (LG_bSetbyProg = False) Then
            My.Computer.FileSystem.WriteAllText(LG_strText, txtText.Text, False, System.Text.Encoding.UTF8)
            GeckoWebBrowser1.SuspendLayout()
            GeckoWebBrowser1.Reload()
            GeckoWebBrowser1.ResumeLayout()
        End If
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        My.Computer.Clipboard.SetText(txtText.Text)
    End Sub

    Private Sub btnFileRef_Click(sender As Object, e As EventArgs)
        Using ofd As New OpenFileDialog()
            ofd.FileName = "default.txt"
            ofd.InitialDirectory = "C:\"
            ofd.Filter = "テキストファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*"
            ofd.FilterIndex = 1
            ofd.Title = "開くファイルを選択してください"
            ofd.RestoreDirectory = True

            If (ofd.ShowDialog() = DialogResult.OK) Then
                Console.WriteLine(ofd.FileName)
            End If
        End Using
    End Sub

    Private Sub tsmi文字修飾_太字_Click(sender As Object, e As EventArgs) Handles tsmi文字修飾_太字.Click

    End Sub
End Class
