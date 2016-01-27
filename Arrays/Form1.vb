Public Class Form1
    Private strClasses() As String = {"Web Design", "Spanish", "Gym", "English", "History", "Calculus"}
    Private myNumbers() As Integer = {1, 2, 3, 4, 5, 6}

    Private Sub btnAddArray_Click(sender As Object, e As EventArgs) Handles btnAddArray.Click
        ClearList()

        AddItemsToList(myNumbers)



    End Sub

    Private Sub ClearList()
        listArrays.Items.Clear()
    End Sub

    Private Sub AddItemsToList(ByVal argArray() As String)
        'Enumerate Array
        For Each item As String In argArray
            'add array item to list
            listArrays.Items.Add(item)
        Next
    End Sub

    Private Sub addItemsToList(ByVal argArray() As Integer
            'Enumerate Array
        For Each item As String In argArray
            'add array item to list
            listArrays.Items.Add(item)
        Next





    Private Sub btnSortArray_Click(sender As Object, e As EventArgs) Handles btnSortArray.Click
        ClearList()

        Array.Sort(strClasses)
        AddItemsToList(strClasses)


    End Sub



    Private Sub btnReverse_Click(sender As Object, e As EventArgs) Handles btnReverse.Click
        ClearList()

        Array.Reverse(strClasses)
        AddItemsToList(strClasses)
        Array.Sort(strClasses)



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        strClasses(0) = "Web Design"
        strClasses(1) = "Spanish"
        strClasses(2) = "Gym"
        strClasses(3) = "English"
        strClasses(4) = "History"
        strClasses(5) = "Calculus"

    End Sub
End Class
