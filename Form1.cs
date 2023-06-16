using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorLite
{
    public partial class Form1 : Form
    {
        #region Установки
        State CurrentState;//текущий статус 
        Status CurrStatus;
        double? preserve;//хранение "модификаторов"
        double? memory;//память
        double? answer;//хранение значения
        
        enum State
        {
            NoState = -1,
            Substraction,
            Addition,
            Multiplication,
            Divide,
            Power,
            Squart,
            Square,
            Inverse,
            RootN
        }

        enum Status
        {
            Nothing,
            HavePreserve,
            ReturnedAnswer
        }

        public Form1()
        {
            InitializeComponent();
            memory = null;
            preserve = null;
            answer = null;
            Value.Text = "0";
            Value.SelectionStart = Value.Text.Length;
            CurrentState = State.NoState;
            CurrStatus = Status.Nothing;
            Вставить.Enabled = Clipboard.GetText() != "";
            КопироватьПамять.Enabled = memory != null; 
            КопироватьПоле.Enabled = Value.Text != string.Empty;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Equally_Click(sender, e); break;
                case Keys.NumPad0:
                case Keys.D0:
                    Num0_Click(sender, e); break;
                case Keys.NumPad1:
                case Keys.D1:
                    Num1_Click(sender, e); break;
                case Keys.NumPad2:
                case Keys.D2:
                    Num2_Click(sender, e); break;
                case Keys.NumPad3:
                case Keys.D3:
                    Num3_Click(sender, e); break;
                case Keys.NumPad4:
                case Keys.D4:
                    Num4_Click(sender, e); break;
                case Keys.NumPad5:
                case Keys.D5:
                    Num5_Click(sender, e); break;
                case Keys.NumPad6:
                case Keys.D6:
                    Num6_Click(sender, e); break;
                case Keys.NumPad7:
                case Keys.D7:
                    Num7_Click(sender, e); break;
                case Keys.NumPad8:
                case Keys.D8:
                    Num8_Click(sender, e); break;
                case Keys.NumPad9:
                case Keys.D9:
                    Num9_Click(sender, e); break;
                case Keys.Add:
                    Addition_Click(sender, e); break;
                case Keys.Oemcomma:
                case Keys.Decimal:
                case Keys.OemPeriod:
                    Comma_Click(sender, e); break;
                case Keys.Subtract:
                    Subtraction_Click(sender,e);break;
                case Keys.Divide:
                    Divide_Click(sender, e);break;
                case Keys.Multiply:
                    Multiplication_Click(sender, e); break;
                case Keys.OemMinus:
                    MemMinus_Click(sender, e);break;
                case Keys.Oemplus:
                    MemPlus_Click(sender, e);break;
                /*case Keys.Back:
                    Backspace_Click(sender, e);break;*/
                /*case Keys.Delete:
                    ClearAll_Click(sender, e); break;*/

            }
        }
        #endregion

        #region Память
        private void MemPlus_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(Value.Text) != null)
                {
                    MemoryClear.Enabled = true;
                    MemReplace.Enabled = true;
                    
                    if(memory != null) memory += double.Parse(Value.Text);
                    else memory = double.Parse(Value.Text);

                    panel1.Text = memory.ToString();

                    КопироватьПамять.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Попытайтесь ввести корректные для данной операции данные и повторите попытку", "Калькулятор", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception)
            {
            }
        }
        private void MemMinus_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(Value.Text) != null)
                {
                    MemoryClear.Enabled = true;
                    MemReplace.Enabled = true;

                    if (memory != null) memory -= double.Parse(Value.Text);
                    else memory = double.Parse(Value.Text);

                    panel1.Text = memory.ToString();

                    КопироватьПамять.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Попытайтесь ввести корректные для данной операции данные и повторите попытку", "Калькулятор", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception)
            {
            }
        }
        private void MemoryClear_Click(object sender, EventArgs e)
        {
            MemoryClear.Enabled = false;
            MemReplace.Enabled = false;
            memory = null;
            panel1.Text = string.Empty;

            КопироватьПамять.Enabled = false;
        }
        private void MemReplace_Click(object sender, EventArgs e)
        {
            Value.Text = memory.ToString();
        }
        #endregion

        #region Циферки
        private void Num1_Click(object sender, EventArgs e)
        {
            if(Value.Text == "0" || CurrStatus != Status.Nothing) Value.Text = "1";
            else Value.Text += "1";
            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void Num2_Click(object sender, EventArgs e)
        {
            if (Value.Text == "0" || CurrStatus != Status.Nothing) Value.Text = "2";
            else Value.Text += "2";
            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void Num3_Click(object sender, EventArgs e)
        {
            if (Value.Text == "0" || CurrStatus != Status.Nothing) Value.Text = "3";
            else Value.Text += "3";
            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void Num4_Click(object sender, EventArgs e)
        {
            if (Value.Text == "0" || CurrStatus != Status.Nothing) Value.Text = "4";
            else Value.Text += "4";
            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void Num5_Click(object sender, EventArgs e)
        {
            if (Value.Text == "0" || CurrStatus != Status.Nothing) Value.Text = "5";
            else Value.Text += "5";
            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void Num6_Click(object sender, EventArgs e)
        {
            if (Value.Text == "0" || CurrStatus != Status.Nothing) Value.Text = "6";
            else Value.Text += "6";
            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void Num7_Click(object sender, EventArgs e)
        {
            if (Value.Text == "0" || CurrStatus != Status.Nothing) Value.Text = "7";
            else Value.Text += "7";
            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void Num8_Click(object sender, EventArgs e)
        {
            if (Value.Text == "0" || CurrStatus != Status.Nothing) Value.Text = "8";
            else Value.Text += "8";
            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void Num9_Click(object sender, EventArgs e)
        {
            if (Value.Text == "0" || CurrStatus != Status.Nothing) Value.Text = "9";
            else Value.Text += "9";
            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void Num0_Click(object sender, EventArgs e)
        {
            if (Value.Text != "0" || CurrStatus != Status.Nothing) Value.Text = "0";
            else Value.Text += "0";

            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void Comma_Click(object sender, EventArgs e)
        {
            if (Value.Text == "0" || CurrStatus != Status.Nothing) Value.Text = "0,";
            else if (Value.Text.Contains(",")) Value.Text = Value.Text.Replace(",", string.Empty);
            Value.Text += ",";
            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void PlusMinus_Click(object sender, EventArgs e)
        {
            try
            {
                if (Value.Text.Contains("-")) Value.Text = Value.Text.Replace("-", string.Empty);
                else Value.Text = "-" + Value.Text;
            }
            catch (Exception) { }
        }
        #endregion

        #region Верхняя панель
        private void КопироватьПамять_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(memory.ToString());
            Вставить.Enabled = Clipboard.GetText() != "";
        }
        private void КопироватьПоле_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Value.Text);
            Вставить.Enabled = Clipboard.GetText() != "";
        }
        private void Вставить_Click(object sender, EventArgs e)
        {
            double a;
            if (double.TryParse(Clipboard.GetText(), out a)) Value.Text = a.ToString();
        }
        private void Инфа_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Info"] == null)
            {
                Info form2 = new Info();
                form2.Activate();
                form2.ShowDialog();
            }
            else
            {
                Application.OpenForms["Info"].Activate();
            }
        }
        #endregion

        #region Инструменты
        private void Clear_Click(object sender, EventArgs e)
        {
            Value.Clear();
            Value.Text = "0";
        }
        private void ClearAll_Click(object sender, EventArgs e)
        {
            Value.Clear();
            Value.Text = "0";
            CurrentState = State.NoState;
            CurrStatus = Status.Nothing;
            answer = null;
            preserve = null;
        }
        private void Backspace_Click(object sender, EventArgs e)
        {
            try
            {
                Value.Text = Value.Text.Substring(0, Value.Text.Length - 1);
                if(Value.Text == "") Value.Text = "0";
            }
            catch (Exception) { }
        }
        private void Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back)
                {
                    if (e.KeyChar == (char)Keys.Back) { }
                    else if (Value.Text.Contains(",") || Value.Text.Contains(".")) e.Handled = true;
                }
                else e.Handled = true;
            }
        }
        #endregion

        #region Калькулятор
        private void Equally_Click(object sender, EventArgs e)
        {
            try
            {
                if (preserve == null) preserve = double.Parse(Value.Text);
                /*else preserve = double.Parse(Value.Text);*/
                switch (CurrentState)
                {
                    case State.NoState:
                        CurrStatus = Status.Nothing;
                        break;

                    case State.Substraction:
                        answer -= (double)preserve;
                        break;
                    case State.Addition:
                        answer += (double)preserve;
                        break;
                    case State.Multiplication:
                        answer *= (double)preserve;
                        break;
                    case State.Divide:
                        answer /= (double)preserve;
                        break;
                    case State.Power:
                        answer = Math.Pow((double)answer, (double)preserve);
                        break;
                    case State.Squart:
                        answer = Math.Sqrt((double)answer);
                        break;
                    case State.Square:
                        answer = Math.Pow((double)answer, 2);
                        break;
                    case State.Inverse:
                        answer = 1 / answer;
                        break;
                    case State.RootN:
                        answer = Math.Pow((double)answer, 1.0 / (double)preserve);
                        break;
                }
                Value.Text = answer.ToString();
                CurrStatus = Status.ReturnedAnswer;
                /*CurrentState = State.NoState;*/
            }
            catch (Exception ex) { MessageBox.Show("Вызвана следующая ошибка\n" + ex.Message, "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            if (CurrentState != State.NoState) Equally_Click(sender, e);
            if (answer == null) answer = double.Parse(Value.Text);

            CurrentState = State.Multiplication;
            CurrStatus = Status.HavePreserve;

            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void Subtraction_Click(object sender, EventArgs e)
        {
            if (CurrentState != State.NoState) Equally_Click(sender, e);
            if (answer == null) answer = double.Parse(Value.Text);

            CurrentState = State.Substraction;
            CurrStatus = Status.HavePreserve;

            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void Divide_Click(object sender, EventArgs e)
        {
            if (CurrentState != State.NoState) Equally_Click(sender, e);
            if (answer == null) answer = double.Parse(Value.Text);

            CurrentState = State.Divide;
            CurrStatus = Status.HavePreserve;

            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void Addition_Click(object sender, EventArgs e)
        {
            if (CurrentState != State.NoState) Equally_Click(sender, e);
            if (answer == null) answer = double.Parse(Value.Text);

            CurrentState = State.Addition;
            CurrStatus = Status.HavePreserve;

            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void Squart_Click(object sender, EventArgs e)
        {
            if (CurrentState != State.NoState) Equally_Click(sender, e);
            if (answer == null) answer = double.Parse(Value.Text);

            CurrentState = State.Squart;
            CurrStatus = Status.HavePreserve;

            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void Inverse_Click(object sender, EventArgs e)
        {
            if (CurrentState != State.NoState) Equally_Click(sender, e);
            if (answer == null) answer = double.Parse(Value.Text);

            CurrentState = State.Inverse;
            CurrStatus = Status.HavePreserve;

            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void Square_Click(object sender, EventArgs e)
        {
            if (CurrentState != State.NoState) Equally_Click(sender, e);
            if (answer == null) answer = double.Parse(Value.Text);

            CurrentState = State.Square;
            CurrStatus = Status.HavePreserve;

            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void Pow_Click(object sender, EventArgs e)
        {
            if (CurrentState != State.NoState) Equally_Click(sender, e);
            if (answer == null) answer = double.Parse(Value.Text);

            CurrentState = State.Power;
            CurrStatus = Status.HavePreserve;

            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        private void RootN_Click(object sender, EventArgs e)
        {
            if (CurrentState != State.NoState) Equally_Click(sender, e);
            if (answer == null) answer = double.Parse(Value.Text);

            CurrentState = State.RootN;
            CurrStatus = Status.HavePreserve;

            Value.Focus();
            Value.SelectionStart = Value.Text.Length;
        }
        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}
