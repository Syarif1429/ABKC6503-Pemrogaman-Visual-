Public Class Form1
    Private strFriends(4) As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strFriends(0) = "Amat"
        strFriends(1) = "Udin"
        strFriends(2) = "Jumiati"
        strFriends(3) = "Tadung"
        strFriends(4) = "Hirang"
    End Sub

    Private Sub AddItemsToList(ByVal arrayList As String())

        For Each strName As String In arrayList

            lstFriends.Items.Add(strName)
        Next
    End Sub


    Private Sub btnOrCheck_Click(sender As Object, e As EventArgs) Handles btnOrCheck.Click
        Dim strName1 As String, strName2 As String

        strName1 = txtName1.Text
        strName2 = txtName2.Text

        If strName1 = "Syarif" Or strName2 = "Syarif" Then
            MessageBox.Show("One of the names is Udin.",
            "And Or Demo")
        Else
            MessageBox.Show("Neither of the names is Udin.", "And Or Demo")
        End If

    End Sub

    Private Sub btnArrayElement_Click(sender As Object, e As EventArgs) Handles btnArrayElement.Click
        Dim strFriends(4) As String

        strFriends(0) = "Amat"
        strFriends(1) = "Udin"
        strFriends(2) = "Jumiati"
        strFriends(3) = "Tadung"
        strFriends(4) = "Hirang"

        lstFriends.Items.Add(strFriends(0))
    End Sub

    Private Sub btnEnumarteArray_Click(sender As Object, e As EventArgs) Handles btnEnumarteArray.Click

        For Each strName As String In strFriends
            lstFriends.Items.Add(strName)
        Next
    End Sub

    Private Sub btnArrayAsParameters_Click(sender As Object, e As EventArgs) Handles btnArrayAsParameters.Click
    End Sub

    Private Sub btnMoreArrayParameters_Click(sender As Object, e As EventArgs) Handles btnMoreArrayParameters.Click
        Dim strMoreFriends(1) As String

        strMoreFriends(0) = "Elaine"
        strMoreFriends(1) = "Debra"

        AddItemsToList(strFriends)
        AddItemsToList(strMoreFriends)
    End Sub

    Private Sub btnSortingArray_Click(sender As Object, e As EventArgs) Handles btnSortingArray.Click
        Array.Sort(strFriends)

        AddItemsToList(strFriends)
    End Sub

    Private Sub btnReversingAnArray_Click(sender As Object, e As EventArgs) Handles btnReversingAnArray.Click
        Array.Reverse(strFriends)
        AddItemsToList(strFriends)
    End Sub

    Private Sub btnIntializingArrayWithVakues_Click(sender As Object, e As EventArgs) Handles btnIntializingArrayWithVakues.Click
        Dim strMyFriends() As String = {"Amat", "Udin", "Jumiati", "Tadung", "Hirang"}
        AddItemsToList(strFriends)
    End Sub

End Class
