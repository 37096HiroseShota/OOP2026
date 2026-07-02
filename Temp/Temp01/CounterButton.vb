Public Class CounterButton : Button { 
    Private int clickCount = 0;

	Public CountButton() {
		Text = "クリック: 0";
		Click += CountButton_Click;
		}

	Private void CountButton_Click(Object sender, EventArgs e) {
		clickCount++;
		Text = clickCount;
	}

}
End Class
