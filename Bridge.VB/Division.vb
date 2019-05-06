Imports Bridge.Abstraction

Public Class Division
    Implements IOperation

    Public Function Operation(inputData As IData) As Double Implements IOperation.Operation
        Return inputData.Value1/inputData.Value2
    End Function
End Class