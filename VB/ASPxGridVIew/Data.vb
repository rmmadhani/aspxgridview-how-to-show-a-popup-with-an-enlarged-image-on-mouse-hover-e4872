Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace ASPxGridVIew
    Public Class Data
        Public Property ID() As Integer
        Public Property Description() As String
        Public Property ImageUrl() As String
    End Class

    Public Class DataHelper
        Public Shared Function GenerateData() As List(Of Data)
            Return New List(Of Data)() From { _
                New Data() With { _
                    .ID = 0, _
                    .Description = "Basket", _
                    .ImageUrl = "Images/Basket.png" _
                }, _
                New Data() With { _
                    .ID = 1, _
                    .Description = "Customer", _
                    .ImageUrl = "Images/Customer.png" _
                }, _
                New Data() With { _
                    .ID = 2, _
                    .Description = "Home", _
                    .ImageUrl = "Images/Home.png" _
                }, _
                New Data() With { _
                    .ID = 3, _
                    .Description = "Mail", _
                    .ImageUrl = "Images/Mail.png" _
                }, _
                New Data() With { _
                    .ID = 4, _
                    .Description = "Check", _
                    .ImageUrl = "Images/Check.png" _
                }, _
                New Data() With { _
                    .ID = 5, _
                    .Description = "Folder", _
                    .ImageUrl = "Images/Folder.png" _
                }, _
                New Data() With { _
                    .ID = 6, _
                    .Description = "Key", _
                    .ImageUrl = "Images/Key.png" _
                }, _
                New Data() With { _
                    .ID = 7, _
                    .Description = "Printing", _
                    .ImageUrl = "Images/Printing.png" _
                } _
            }
        End Function
    End Class
End Namespace