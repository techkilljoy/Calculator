Public Class Form1
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Descr:  Updates calculator display 
    'pre:  A boolean var indicates if the key press is part of a new number (changed on a math function key press) or if it should be added to the current number
    'post:  the display either contains a new number or an additional digit for the existing number.  If the key press was the first number in a new number change the boolean var indicating a new number to False
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Private Sub btnNumber_Click(byval sender as Object, byval e as System.EventArgs)handles '???

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Descr:  Clears the display
    'pre: none
    'post:  display contains 0 and global vars are cleared, the boolean var indicating the last key press was an operator is set to true
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Private Sub btnClear_Click(byval sender as Object, byval e as System.EventArgs)handles '???

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Descr:  Closes app
    'pre:  none
    'post:  Program ends
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Private Sub btnOff_Click(byval sender as Object, byval e as System.EventArgs)handles '???

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Descr:  Updates the value of the operands and shows the result of a calculation if 2 operands have been entered 
    'pre: none
    'post:The value of the first operand is assigned the value of the display if an operator has not been previously clicked or the equal sign was the last operator clicked.
    'If an operator has been previously clicked, the second operand is assigned the value in the display and the result is displayed.
    'The boolean var indicating that all future numbers are part of a new number is set to true
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Private Sub btnOperator_Click(byval sender as Object, byval e as System.EventArgs) handles '???????

    End Sub


    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Descr:  Returns the result of a calculation
    'pre:  none
    'post:  The result of a calculation involving two operands has been performed
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Function Calculate(ByVal sngFirstOperand As Single, ByVal sngSecondOperand As Single, ByVal byvalstrOperator As String) As Single

    End Function

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

