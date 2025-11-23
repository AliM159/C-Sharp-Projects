namespace GenericsStack
{
    public partial class StackImplementationApp : Form
    {

        GenericStack<int> intStack = new GenericStack<int>();
        GenericStack<string> stringStack = new GenericStack<string>();

        public StackImplementationApp()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Select", "int", "string" });
            comboBox1.SelectedIndex = 0;
        }

        private void StackImplementationApp_Load(object sender, EventArgs e)
        {

        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            string selectedType = comboBox1.SelectedItem?.ToString();
            string input = textBox1.Text.Trim();

            if (selectedType == "int")
            {
                if (int.TryParse(input, out int number))
                {
                    try
                    {
                        intStack.Push(number);
                        UpdateStackList(intStack);
                        lbStatus.Text = $"  Pushed: {number}";
                    }
                    catch (Exception ex)
                    {
                        lbStatus.Text = $" {ex.Message}";
                    }
                }
                else
                {
                    lbStatus.Text = " Please enter a valid integer.";
                }
            }
            else if (selectedType == "string")
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    lbStatus.Text = " String input cannot be empty.";
                    return;
                }

                try
                {
                    stringStack.Push(input);
                    UpdateStackList(stringStack);
                    lbStatus.Text = $" Pushed: {input}";
                }
                catch (Exception ex)
                {
                    lbStatus.Text = $" {ex.Message}";
                }
            }
            else
            {
                lbStatus.Text = " Please select a type.";
            }
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            string selectedType = comboBox1.SelectedItem?.ToString();

            if (selectedType == "int")
            {
                try
                {
                    int popped = intStack.Pop();
                    UpdateStackList(intStack);
                    lbStatus.Text = $" Popped: {popped}";
                }
                catch (Exception ex)
                {
                    lbStatus.Text = $" {ex.Message}";
                }
            }
            else if (selectedType == "string")
            {
                try
                {
                    string popped = stringStack.Pop();
                    UpdateStackList(stringStack);
                    lbStatus.Text = $" Popped: {popped}";
                }
                catch (Exception ex)
                {
                    lbStatus.Text = $" {ex.Message}";
                }
            }
            else
            {
                lbStatus.Text = " Please select a type.";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string selectedType = comboBox1.SelectedItem?.ToString();

            if (selectedType == "int")
                intStack = new GenericStack<int>();
            else if (selectedType == "string")
                stringStack = new GenericStack<string>();

            comboBox1.SelectedIndex = 0;
            textBox1.Clear();
            listBox.Items.Clear();
            lbStatus.Text = " Stack cleared.";
        }

        private void UpdateStackList<T>(GenericStack<T> stack)
        {
            listBox.Items.Clear();
            for (int i = stack.TopIndex; i >= 0; i--)
            {
                listBox.Items.Add(stack.GetItemAt(i));
            }
        }
    }
}
