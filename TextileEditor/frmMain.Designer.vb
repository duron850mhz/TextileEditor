<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.cmsText = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmi文字修飾 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi文字修飾_太字 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi文字修飾_斜体 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi文字修飾_下線 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi文字修飾_取消線 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi文字修飾_引用 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi文字修飾_等幅フォント = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi文字修飾_書式無効 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi段落 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi段落_右寄せ = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi段落_センタリング = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi段落_左インデント = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi段落_右インデント = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi段落_引用 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi箇条書き = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi箇条書き_リスト = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi箇条書き_番号付リスト = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi見出し = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi見出し_h1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi見出し_h2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi見出し_h3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi見出し_h4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi見出し_h5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi見出し_h6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi水平線 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiリンク = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiテーブル = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiテーブル_テーブル = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiテーブル_ヘッダ = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiテーブル_左寄せ = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiテーブル_右寄せ = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiテーブル_センタリング = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiテーブル_上揃え = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiテーブル_下揃え = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiテーブル_横方向結合 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiテーブル_縦方向結合 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi整形済テキスト = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GeckoWebBrowser1 = New Gecko.GeckoWebBrowser()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.cmsFile = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ファイルToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.新規作成ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.開くToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.保存SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.名前を付けて保存AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.終了QToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cmsText.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.cmsFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtText
        '
        Me.txtText.ContextMenuStrip = Me.cmsText
        Me.txtText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtText.Location = New System.Drawing.Point(0, 0)
        Me.txtText.Multiline = True
        Me.txtText.Name = "txtText"
        Me.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtText.Size = New System.Drawing.Size(388, 397)
        Me.txtText.TabIndex = 0
        '
        'cmsText
        '
        Me.cmsText.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi文字修飾, Me.tsmi段落, Me.tsmi箇条書き, Me.tsmi見出し, Me.tsmi水平線, Me.tsmiリンク, Me.tsmiテーブル, Me.tsmi整形済テキスト})
        Me.cmsText.Name = "cmsText"
        Me.cmsText.Size = New System.Drawing.Size(143, 180)
        '
        'tsmi文字修飾
        '
        Me.tsmi文字修飾.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi文字修飾_太字, Me.tsmi文字修飾_斜体, Me.tsmi文字修飾_下線, Me.tsmi文字修飾_取消線, Me.tsmi文字修飾_引用, Me.tsmi文字修飾_等幅フォント, Me.tsmi文字修飾_書式無効})
        Me.tsmi文字修飾.Name = "tsmi文字修飾"
        Me.tsmi文字修飾.Size = New System.Drawing.Size(142, 22)
        Me.tsmi文字修飾.Text = "文字修飾"
        '
        'tsmi文字修飾_太字
        '
        Me.tsmi文字修飾_太字.Name = "tsmi文字修飾_太字"
        Me.tsmi文字修飾_太字.Size = New System.Drawing.Size(127, 22)
        Me.tsmi文字修飾_太字.Text = "太字"
        '
        'tsmi文字修飾_斜体
        '
        Me.tsmi文字修飾_斜体.Name = "tsmi文字修飾_斜体"
        Me.tsmi文字修飾_斜体.Size = New System.Drawing.Size(127, 22)
        Me.tsmi文字修飾_斜体.Text = "斜体"
        '
        'tsmi文字修飾_下線
        '
        Me.tsmi文字修飾_下線.Name = "tsmi文字修飾_下線"
        Me.tsmi文字修飾_下線.Size = New System.Drawing.Size(127, 22)
        Me.tsmi文字修飾_下線.Text = "下線"
        '
        'tsmi文字修飾_取消線
        '
        Me.tsmi文字修飾_取消線.Name = "tsmi文字修飾_取消線"
        Me.tsmi文字修飾_取消線.Size = New System.Drawing.Size(127, 22)
        Me.tsmi文字修飾_取消線.Text = "取消線"
        '
        'tsmi文字修飾_引用
        '
        Me.tsmi文字修飾_引用.Name = "tsmi文字修飾_引用"
        Me.tsmi文字修飾_引用.Size = New System.Drawing.Size(127, 22)
        Me.tsmi文字修飾_引用.Text = "引用"
        '
        'tsmi文字修飾_等幅フォント
        '
        Me.tsmi文字修飾_等幅フォント.Name = "tsmi文字修飾_等幅フォント"
        Me.tsmi文字修飾_等幅フォント.Size = New System.Drawing.Size(127, 22)
        Me.tsmi文字修飾_等幅フォント.Text = "等幅フォント"
        '
        'tsmi文字修飾_書式無効
        '
        Me.tsmi文字修飾_書式無効.Name = "tsmi文字修飾_書式無効"
        Me.tsmi文字修飾_書式無効.Size = New System.Drawing.Size(127, 22)
        Me.tsmi文字修飾_書式無効.Text = "書式無効"
        '
        'tsmi段落
        '
        Me.tsmi段落.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi段落_右寄せ, Me.tsmi段落_センタリング, Me.tsmi段落_左インデント, Me.tsmi段落_右インデント, Me.tsmi段落_引用})
        Me.tsmi段落.Name = "tsmi段落"
        Me.tsmi段落.Size = New System.Drawing.Size(142, 22)
        Me.tsmi段落.Text = "段落"
        '
        'tsmi段落_右寄せ
        '
        Me.tsmi段落_右寄せ.Name = "tsmi段落_右寄せ"
        Me.tsmi段落_右寄せ.Size = New System.Drawing.Size(127, 22)
        Me.tsmi段落_右寄せ.Text = "右寄せ"
        '
        'tsmi段落_センタリング
        '
        Me.tsmi段落_センタリング.Name = "tsmi段落_センタリング"
        Me.tsmi段落_センタリング.Size = New System.Drawing.Size(127, 22)
        Me.tsmi段落_センタリング.Text = "センタリング"
        '
        'tsmi段落_左インデント
        '
        Me.tsmi段落_左インデント.Name = "tsmi段落_左インデント"
        Me.tsmi段落_左インデント.Size = New System.Drawing.Size(127, 22)
        Me.tsmi段落_左インデント.Text = "左インデント"
        '
        'tsmi段落_右インデント
        '
        Me.tsmi段落_右インデント.Name = "tsmi段落_右インデント"
        Me.tsmi段落_右インデント.Size = New System.Drawing.Size(127, 22)
        Me.tsmi段落_右インデント.Text = "右インデント"
        '
        'tsmi段落_引用
        '
        Me.tsmi段落_引用.Name = "tsmi段落_引用"
        Me.tsmi段落_引用.Size = New System.Drawing.Size(127, 22)
        Me.tsmi段落_引用.Text = "引用"
        '
        'tsmi箇条書き
        '
        Me.tsmi箇条書き.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi箇条書き_リスト, Me.tsmi箇条書き_番号付リスト})
        Me.tsmi箇条書き.Name = "tsmi箇条書き"
        Me.tsmi箇条書き.Size = New System.Drawing.Size(142, 22)
        Me.tsmi箇条書き.Text = "箇条書き"
        '
        'tsmi箇条書き_リスト
        '
        Me.tsmi箇条書き_リスト.Name = "tsmi箇条書き_リスト"
        Me.tsmi箇条書き_リスト.Size = New System.Drawing.Size(130, 22)
        Me.tsmi箇条書き_リスト.Text = "リスト"
        '
        'tsmi箇条書き_番号付リスト
        '
        Me.tsmi箇条書き_番号付リスト.Name = "tsmi箇条書き_番号付リスト"
        Me.tsmi箇条書き_番号付リスト.Size = New System.Drawing.Size(130, 22)
        Me.tsmi箇条書き_番号付リスト.Text = "番号付リスト"
        '
        'tsmi見出し
        '
        Me.tsmi見出し.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi見出し_h1, Me.tsmi見出し_h2, Me.tsmi見出し_h3, Me.tsmi見出し_h4, Me.tsmi見出し_h5, Me.tsmi見出し_h6})
        Me.tsmi見出し.Name = "tsmi見出し"
        Me.tsmi見出し.Size = New System.Drawing.Size(142, 22)
        Me.tsmi見出し.Text = "見出し"
        '
        'tsmi見出し_h1
        '
        Me.tsmi見出し_h1.Name = "tsmi見出し_h1"
        Me.tsmi見出し_h1.Size = New System.Drawing.Size(82, 22)
        Me.tsmi見出し_h1.Text = "h1"
        '
        'tsmi見出し_h2
        '
        Me.tsmi見出し_h2.Name = "tsmi見出し_h2"
        Me.tsmi見出し_h2.Size = New System.Drawing.Size(82, 22)
        Me.tsmi見出し_h2.Text = "h2"
        '
        'tsmi見出し_h3
        '
        Me.tsmi見出し_h3.Name = "tsmi見出し_h3"
        Me.tsmi見出し_h3.Size = New System.Drawing.Size(82, 22)
        Me.tsmi見出し_h3.Text = "h3"
        '
        'tsmi見出し_h4
        '
        Me.tsmi見出し_h4.Name = "tsmi見出し_h4"
        Me.tsmi見出し_h4.Size = New System.Drawing.Size(82, 22)
        Me.tsmi見出し_h4.Text = "h4"
        '
        'tsmi見出し_h5
        '
        Me.tsmi見出し_h5.Name = "tsmi見出し_h5"
        Me.tsmi見出し_h5.Size = New System.Drawing.Size(82, 22)
        Me.tsmi見出し_h5.Text = "h5"
        '
        'tsmi見出し_h6
        '
        Me.tsmi見出し_h6.Name = "tsmi見出し_h6"
        Me.tsmi見出し_h6.Size = New System.Drawing.Size(82, 22)
        Me.tsmi見出し_h6.Text = "h6"
        '
        'tsmi水平線
        '
        Me.tsmi水平線.Name = "tsmi水平線"
        Me.tsmi水平線.Size = New System.Drawing.Size(142, 22)
        Me.tsmi水平線.Text = "水平線"
        '
        'tsmiリンク
        '
        Me.tsmiリンク.Name = "tsmiリンク"
        Me.tsmiリンク.Size = New System.Drawing.Size(142, 22)
        Me.tsmiリンク.Text = "リンク"
        '
        'tsmiテーブル
        '
        Me.tsmiテーブル.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiテーブル_テーブル, Me.tsmiテーブル_ヘッダ, Me.tsmiテーブル_左寄せ, Me.tsmiテーブル_右寄せ, Me.tsmiテーブル_センタリング, Me.tsmiテーブル_上揃え, Me.tsmiテーブル_下揃え, Me.tsmiテーブル_横方向結合, Me.tsmiテーブル_縦方向結合})
        Me.tsmiテーブル.Name = "tsmiテーブル"
        Me.tsmiテーブル.Size = New System.Drawing.Size(142, 22)
        Me.tsmiテーブル.Text = "テーブル"
        '
        'tsmiテーブル_テーブル
        '
        Me.tsmiテーブル_テーブル.Name = "tsmiテーブル_テーブル"
        Me.tsmiテーブル_テーブル.Size = New System.Drawing.Size(130, 22)
        Me.tsmiテーブル_テーブル.Text = "テーブル"
        '
        'tsmiテーブル_ヘッダ
        '
        Me.tsmiテーブル_ヘッダ.Name = "tsmiテーブル_ヘッダ"
        Me.tsmiテーブル_ヘッダ.Size = New System.Drawing.Size(130, 22)
        Me.tsmiテーブル_ヘッダ.Text = "ヘッダ"
        '
        'tsmiテーブル_左寄せ
        '
        Me.tsmiテーブル_左寄せ.Name = "tsmiテーブル_左寄せ"
        Me.tsmiテーブル_左寄せ.Size = New System.Drawing.Size(130, 22)
        Me.tsmiテーブル_左寄せ.Text = "左寄せ"
        '
        'tsmiテーブル_右寄せ
        '
        Me.tsmiテーブル_右寄せ.Name = "tsmiテーブル_右寄せ"
        Me.tsmiテーブル_右寄せ.Size = New System.Drawing.Size(130, 22)
        Me.tsmiテーブル_右寄せ.Text = "右寄せ"
        '
        'tsmiテーブル_センタリング
        '
        Me.tsmiテーブル_センタリング.Name = "tsmiテーブル_センタリング"
        Me.tsmiテーブル_センタリング.Size = New System.Drawing.Size(130, 22)
        Me.tsmiテーブル_センタリング.Text = "センタリング"
        '
        'tsmiテーブル_上揃え
        '
        Me.tsmiテーブル_上揃え.Name = "tsmiテーブル_上揃え"
        Me.tsmiテーブル_上揃え.Size = New System.Drawing.Size(130, 22)
        Me.tsmiテーブル_上揃え.Text = "上揃え"
        '
        'tsmiテーブル_下揃え
        '
        Me.tsmiテーブル_下揃え.Name = "tsmiテーブル_下揃え"
        Me.tsmiテーブル_下揃え.Size = New System.Drawing.Size(130, 22)
        Me.tsmiテーブル_下揃え.Text = "下揃え"
        '
        'tsmiテーブル_横方向結合
        '
        Me.tsmiテーブル_横方向結合.Name = "tsmiテーブル_横方向結合"
        Me.tsmiテーブル_横方向結合.Size = New System.Drawing.Size(130, 22)
        Me.tsmiテーブル_横方向結合.Text = "横方向結合"
        '
        'tsmiテーブル_縦方向結合
        '
        Me.tsmiテーブル_縦方向結合.Name = "tsmiテーブル_縦方向結合"
        Me.tsmiテーブル_縦方向結合.Size = New System.Drawing.Size(130, 22)
        Me.tsmiテーブル_縦方向結合.Text = "縦方向結合"
        '
        'tsmi整形済テキスト
        '
        Me.tsmi整形済テキスト.Name = "tsmi整形済テキスト"
        Me.tsmi整形済テキスト.Size = New System.Drawing.Size(142, 22)
        Me.tsmi整形済テキスト.Text = "整形済テキスト"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 12)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtText)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GeckoWebBrowser1)
        Me.SplitContainer1.Size = New System.Drawing.Size(776, 397)
        Me.SplitContainer1.SplitterDistance = 388
        Me.SplitContainer1.TabIndex = 1
        '
        'GeckoWebBrowser1
        '
        Me.GeckoWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GeckoWebBrowser1.FrameEventsPropagateToMainWindow = False
        Me.GeckoWebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.GeckoWebBrowser1.Name = "GeckoWebBrowser1"
        Me.GeckoWebBrowser1.Size = New System.Drawing.Size(384, 397)
        Me.GeckoWebBrowser1.TabIndex = 0
        Me.GeckoWebBrowser1.UseHttpActivityObserver = False
        '
        'btnCopy
        '
        Me.btnCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCopy.Location = New System.Drawing.Point(632, 415)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(75, 23)
        Me.btnCopy.TabIndex = 1
        Me.btnCopy.Text = "コピー"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'cmsFile
        '
        Me.cmsFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルToolStripMenuItem, Me.ToolStripMenuItem2, Me.終了QToolStripMenuItem})
        Me.cmsFile.Name = "cmsFile"
        Me.cmsFile.Size = New System.Drawing.Size(120, 54)
        '
        'ファイルToolStripMenuItem
        '
        Me.ファイルToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新規作成ToolStripMenuItem, Me.開くToolStripMenuItem, Me.保存SToolStripMenuItem, Me.名前を付けて保存AToolStripMenuItem})
        Me.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem"
        Me.ファイルToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ファイルToolStripMenuItem.Text = "ファイル(&F)"
        '
        '新規作成ToolStripMenuItem
        '
        Me.新規作成ToolStripMenuItem.Name = "新規作成ToolStripMenuItem"
        Me.新規作成ToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.新規作成ToolStripMenuItem.Text = "新規作成(&N)"
        '
        '開くToolStripMenuItem
        '
        Me.開くToolStripMenuItem.Name = "開くToolStripMenuItem"
        Me.開くToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.開くToolStripMenuItem.Text = "開く(&O)"
        '
        '保存SToolStripMenuItem
        '
        Me.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem"
        Me.保存SToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.保存SToolStripMenuItem.Text = "保存(&S)"
        '
        '名前を付けて保存AToolStripMenuItem
        '
        Me.名前を付けて保存AToolStripMenuItem.Name = "名前を付けて保存AToolStripMenuItem"
        Me.名前を付けて保存AToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.名前を付けて保存AToolStripMenuItem.Text = "名前を付けて保存(&A)"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(116, 6)
        '
        '終了QToolStripMenuItem
        '
        Me.終了QToolStripMenuItem.Name = "終了QToolStripMenuItem"
        Me.終了QToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.終了QToolStripMenuItem.Text = "終了(&Q)"
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.Location = New System.Drawing.Point(713, 415)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "終了"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(12, 415)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "取消"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ContextMenuStrip = Me.cmsFile
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmMain"
        Me.Text = "textile形式で書くやつ"
        Me.cmsText.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.cmsFile.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtText As TextBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnCopy As Button
    Friend WithEvents GeckoWebBrowser1 As Gecko.GeckoWebBrowser
    Friend WithEvents cmsText As ContextMenuStrip
    Friend WithEvents tsmi文字修飾 As ToolStripMenuItem
    Friend WithEvents tsmi文字修飾_太字 As ToolStripMenuItem
    Friend WithEvents tsmi文字修飾_斜体 As ToolStripMenuItem
    Friend WithEvents tsmi文字修飾_下線 As ToolStripMenuItem
    Friend WithEvents tsmi文字修飾_取消線 As ToolStripMenuItem
    Friend WithEvents tsmi文字修飾_引用 As ToolStripMenuItem
    Friend WithEvents tsmi文字修飾_等幅フォント As ToolStripMenuItem
    Friend WithEvents tsmi文字修飾_書式無効 As ToolStripMenuItem
    Friend WithEvents tsmi段落 As ToolStripMenuItem
    Friend WithEvents tsmi段落_右寄せ As ToolStripMenuItem
    Friend WithEvents tsmi段落_センタリング As ToolStripMenuItem
    Friend WithEvents tsmi段落_左インデント As ToolStripMenuItem
    Friend WithEvents tsmi段落_右インデント As ToolStripMenuItem
    Friend WithEvents tsmi段落_引用 As ToolStripMenuItem
    Friend WithEvents tsmi箇条書き As ToolStripMenuItem
    Friend WithEvents tsmi箇条書き_リスト As ToolStripMenuItem
    Friend WithEvents tsmi箇条書き_番号付リスト As ToolStripMenuItem
    Friend WithEvents tsmi見出し As ToolStripMenuItem
    Friend WithEvents tsmi見出し_h1 As ToolStripMenuItem
    Friend WithEvents tsmi見出し_h2 As ToolStripMenuItem
    Friend WithEvents tsmi見出し_h3 As ToolStripMenuItem
    Friend WithEvents tsmi見出し_h4 As ToolStripMenuItem
    Friend WithEvents tsmi見出し_h5 As ToolStripMenuItem
    Friend WithEvents tsmi見出し_h6 As ToolStripMenuItem
    Friend WithEvents tsmi水平線 As ToolStripMenuItem
    Friend WithEvents tsmiリンク As ToolStripMenuItem
    Friend WithEvents tsmiテーブル As ToolStripMenuItem
    Friend WithEvents tsmiテーブル_テーブル As ToolStripMenuItem
    Friend WithEvents tsmiテーブル_ヘッダ As ToolStripMenuItem
    Friend WithEvents tsmiテーブル_左寄せ As ToolStripMenuItem
    Friend WithEvents tsmiテーブル_右寄せ As ToolStripMenuItem
    Friend WithEvents tsmiテーブル_センタリング As ToolStripMenuItem
    Friend WithEvents tsmiテーブル_上揃え As ToolStripMenuItem
    Friend WithEvents tsmiテーブル_下揃え As ToolStripMenuItem
    Friend WithEvents tsmiテーブル_横方向結合 As ToolStripMenuItem
    Friend WithEvents tsmiテーブル_縦方向結合 As ToolStripMenuItem
    Friend WithEvents tsmi整形済テキスト As ToolStripMenuItem
    Friend WithEvents cmsFile As ContextMenuStrip
    Friend WithEvents ファイルToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 新規作成ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 開くToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 保存SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 名前を付けて保存AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents 終了QToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnCancel As Button
End Class
