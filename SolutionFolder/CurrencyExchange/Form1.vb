Imports System.Globalization

Public Class Form1
    Dim ConversionDic As Dictionary(Of String, Decimal) = New Dictionary(Of String, Decimal)


    Public Sub Correction()
        ConversionDic.Add("USD", 1)
        ConversionDic.Add("C$USD", 0.77)
        ConversionDic.Add("Euro", 1)
        ConversionDic.Add("Peso", 0.05)
        ConversionDic.Add("Yen", 0.0073)
        ConversionDic.Add("Ruble", 0.017)
        ConversionDic.Add("Rupee", 0.017)
        ConversionDic.Add("Dirham", 0.27)
        ConversionDic.Add("Won", 0.00075)
        ConversionDic.Add("Pound", 1.18)
        ConversionDic.Add("DK Krone", 0.13)
    End Sub

    Dim I As Decimal
    Dim O As Decimal
    Dim O_T As String

    Public Sub Process(I0 As String)
        Dim I00 = Val(I0)
        Dim O0 = (I00 * I) / O

        OutputData.Text = O0.ToString("N", CultureInfo.InvariantCulture)
    End Sub

    Private Sub InputBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InputBox.SelectedIndexChanged
        InputLabel.Text = "Input: " + InputBox.Items(InputBox.SelectedIndex)
        I = ConversionDic(InputBox.Items(InputBox.SelectedIndex))

        Process(InputData.Text)
    End Sub

    Private Sub OutputBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OutputBox.SelectedIndexChanged
        OutputLabel.Text = "Output: " + OutputBox.Items(OutputBox.SelectedIndex)
        O_T = OutputBox.Items(OutputBox.SelectedIndex)
        O = ConversionDic(O_T)
        Process(InputData.Text)
    End Sub

    Private Sub InputData_TextChanged(sender As Object, e As EventArgs) Handles InputData.TextChanged
        Process(InputData.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Correction()
        I = ConversionDic("USD")
        O = ConversionDic("C$USD")
    End Sub
End Class
