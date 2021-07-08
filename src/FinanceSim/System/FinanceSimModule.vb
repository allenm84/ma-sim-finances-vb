Imports System.Runtime.CompilerServices
Imports Newtonsoft.Json

Module FinanceSimModule
  Public ReadOnly JsonConvertSettings As New JsonSerializerSettings With {
    .TypeNameHandling = TypeNameHandling.Auto
  }

  <Extension>
  Public Function IsEndOfMonth(value As Date) As Boolean
    Dim days = Date.DaysInMonth(value.Year, value.Month)
    Dim endOfMonth = New Date(value.Year, value.Month, days)
    Return endOfMonth = value.Date
  End Function

  <Extension>
  Public Function SafeDequeue(Of T)(target As Queue(Of T)) As T
    If target.Count > 0
      Return target.Dequeue()
    End If
    Return Nothing
  End Function

  <Extension>
  Public Function Clamp(value As Integer, min As Integer, max As Integer)
    Return Math.Max(min, Math.Min(value, max))
  End Function

  <Extension>
  Public Function Clamp(value As Decimal, min As Decimal, max As Decimal)
    Return Math.Max(min, Math.Min(value, max))
  End Function

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

  <Extension>
  Public Iterator Function GetAccounts(profile As Profile) As IEnumerable(Of IAccount)
    For Each bankAccount In profile.Accounts
      Yield bankAccount
    Next

    For Each debt In profile.Debts.Where(Function(it) it.Type = DebtType.Revolving)
      Yield debt
    Next
  End Function

  <Extension>
  Public Function Clone (Of T)(value As T) As T
    Dim json = JsonConvert.SerializeObject(value, JsonConvertSettings)
    Return JsonConvert.DeserializeObject (Of T)(json, JsonConvertSettings)
  End Function
End Module
