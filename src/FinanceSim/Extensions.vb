Imports System.Runtime.CompilerServices

Module Extensions
  <Extension>
  Public Sub InitializeForDecimal(upDown As NumericUpDown)
    upDown.Minimum = 0
    upDown.Maximum = Decimal.MaxValue - 1
  End Sub

  <Extension>
  Public Sub InitializeForInteger(upDown As NumericUpDown)
    upDown.Minimum = 0
    upDown.Maximum = Integer.MaxValue - 1
  End Sub

  <Extension>
  Public Sub SetValue(picker As DateTimePicker, value As Date)
    picker.Value = If(value > picker.MaxDate, picker.MaxDate, If(value < picker.MinDate, picker.MinDate, value))
  End Sub
End Module
