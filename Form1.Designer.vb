<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dtvMatrizPrincipal = New DataGridView()
        dtvNuevaMatriz = New DataGridView()
        dtvVector = New DataGridView()
        Label1 = New Label()
        txtMayor = New TextBox()
        cmdEjecutar = New Button()
        cmdCargarMatriz = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CType(dtvMatrizPrincipal, ComponentModel.ISupportInitialize).BeginInit()
        CType(dtvNuevaMatriz, ComponentModel.ISupportInitialize).BeginInit()
        CType(dtvVector, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtvMatrizPrincipal
        ' 
        dtvMatrizPrincipal.BackgroundColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        dtvMatrizPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtvMatrizPrincipal.Location = New Point(36, 53)
        dtvMatrizPrincipal.Name = "dtvMatrizPrincipal"
        dtvMatrizPrincipal.RowHeadersWidth = 51
        dtvMatrizPrincipal.Size = New Size(380, 312)
        dtvMatrizPrincipal.TabIndex = 0
        ' 
        ' dtvNuevaMatriz
        ' 
        dtvNuevaMatriz.BackgroundColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        dtvNuevaMatriz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtvNuevaMatriz.Location = New Point(677, 53)
        dtvNuevaMatriz.Name = "dtvNuevaMatriz"
        dtvNuevaMatriz.RowHeadersWidth = 51
        dtvNuevaMatriz.Size = New Size(242, 179)
        dtvNuevaMatriz.TabIndex = 1
        ' 
        ' dtvVector
        ' 
        dtvVector.BackgroundColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        dtvVector.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtvVector.Location = New Point(600, 282)
        dtvVector.Name = "dtvVector"
        dtvVector.RowHeadersWidth = 51
        dtvVector.Size = New Size(392, 83)
        dtvVector.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label1.Location = New Point(36, 375)
        Label1.Name = "Label1"
        Label1.Size = New Size(338, 32)
        Label1.TabIndex = 3
        Label1.Text = "Mayor Valor Contradiagonal"
        ' 
        ' txtMayor
        ' 
        txtMayor.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        txtMayor.Location = New Point(171, 428)
        txtMayor.Name = "txtMayor"
        txtMayor.Size = New Size(68, 41)
        txtMayor.TabIndex = 4
        txtMayor.TextAlign = HorizontalAlignment.Center
        ' 
        ' cmdEjecutar
        ' 
        cmdEjecutar.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        cmdEjecutar.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        cmdEjecutar.Location = New Point(619, 490)
        cmdEjecutar.Name = "cmdEjecutar"
        cmdEjecutar.Size = New Size(324, 94)
        cmdEjecutar.TabIndex = 5
        cmdEjecutar.Text = "Ejecutar"
        cmdEjecutar.UseVisualStyleBackColor = False
        ' 
        ' cmdCargarMatriz
        ' 
        cmdCargarMatriz.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        cmdCargarMatriz.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        cmdCargarMatriz.Location = New Point(36, 490)
        cmdCargarMatriz.Name = "cmdCargarMatriz"
        cmdCargarMatriz.Size = New Size(380, 94)
        cmdCargarMatriz.TabIndex = 6
        cmdCargarMatriz.Text = "Cargar Matriz"
        cmdCargarMatriz.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.Location = New Point(36, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(163, 28)
        Label2.TabIndex = 7
        Label2.Text = "Matriz Principal"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.Location = New Point(677, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(147, 28)
        Label3.TabIndex = 8
        Label3.Text = "Nueva Matriz "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.Location = New Point(600, 246)
        Label4.Name = "Label4"
        Label4.Size = New Size(173, 28)
        Label4.TabIndex = 9
        Label4.Text = "Vector Solicitado"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleTurquoise
        ClientSize = New Size(1032, 598)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(cmdCargarMatriz)
        Controls.Add(cmdEjecutar)
        Controls.Add(txtMayor)
        Controls.Add(Label1)
        Controls.Add(dtvVector)
        Controls.Add(dtvNuevaMatriz)
        Controls.Add(dtvMatrizPrincipal)
        Font = New Font("Segoe UI", 10F)
        Name = "Form1"
        Text = "Matrices y Vectores"
        CType(dtvMatrizPrincipal, ComponentModel.ISupportInitialize).EndInit()
        CType(dtvNuevaMatriz, ComponentModel.ISupportInitialize).EndInit()
        CType(dtvVector, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtvMatrizPrincipal As DataGridView
    Friend WithEvents dtvNuevaMatriz As DataGridView
    Friend WithEvents dtvVector As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMayor As TextBox
    Friend WithEvents cmdEjecutar As Button
    Friend WithEvents cmdCargarMatriz As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

End Class
