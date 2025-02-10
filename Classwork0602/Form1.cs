namespace Classwork0602
{
    public partial class Form1 : Form
    {
        private string[,] questions = new string[,]
        {
            { "Столиця Франції?", "Париж" },
            { "2 + 2 = ?", "4" },
            { "Який колір у неба?", "синій" },
            { "Скільки континентів на Землі?", "7" },
            { "Яка планета найближча до Сонця?", "Меркурій" }
        };

        private int currentQuestionIndex = 0;
        private int correctAnswers = 0;
        private int attemptCount = 0;
        private int totalAttempts = 0;
        private int totalQuestions;
        private List<string> history = new List<string>();

        public Form1()
        {
            InitializeComponent();
            totalQuestions = questions.GetLength(0);
            ShowNextQuestion();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string userAnswer = txtAnswer.Text.Trim().ToLower();
            string correctAnswer = questions[currentQuestionIndex, 1].ToLower();

            totalAttempts++;
            lblTotalAttempts.Text = $"Загальна кількість спроб: {totalAttempts}";

            if (userAnswer == correctAnswer)
            {
                MessageBox.Show("Правильно!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblResult.Text = "Правильно!";
                lblResult.ForeColor = Color.Green;
                correctAnswers++;

                history.Add($"Питання: {questions[currentQuestionIndex, 0]}\n" +
                            $"Відповідь: {txtAnswer.Text}\n" +
                            $"Спроби: {attemptCount + 1}\n" +
                            $"Статус: ✅");

                NextQuestion();
            }
            else
            {
                lblResult.Text = "Неправильно!";
                lblResult.ForeColor = Color.Red;
                attemptCount++;
                lblTotalAttempts.Text = $"Спроби: {attemptCount}";

                DialogResult retry = MessageBox.Show($"Неправильно! Хочете спробувати ще раз?",
                                                     "Результат", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (retry == DialogResult.No)
                {
                    history.Add($"Питання: {questions[currentQuestionIndex, 0]}\n" +
                                $"Ваша відповідь: {txtAnswer.Text}\n" +
                                $"Правильна відповідь: {questions[currentQuestionIndex, 1]}\n" +
                                $"Спроби: {attemptCount}\n" +
                                $"Статус: ❌");

                    NextQuestion();
                }
                else
                {
                    txtAnswer.Clear();
                }
            }
        }

        private void NextQuestion()
        {
            attemptCount = 0;
            lblTotalAttempts.Text = $"Спроби: {attemptCount}";
            currentQuestionIndex++;
            
            if (currentQuestionIndex < totalQuestions)
            {
                ShowNextQuestion();
            }
            else
            {
                MessageBox.Show($"Гра завершена!\n" +
                                $"Правильні відповіді: {correctAnswers} із {totalQuestions}.\n\n" +
                                $"Історія відповідей:\n{string.Join("\n\n", history)}",
                                "Кінець гри", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblEndMessage.Text = $"Гра завершена! Ви відповіли правильно на {correctAnswers} із {totalQuestions} питань.";
                lblEndMessage.Visible = true;

                DialogResult restart = MessageBox.Show("Бажаєте пройти вікторину ще раз?",
                                                       "Перезапуск", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (restart == DialogResult.Yes)
                {
                    RestartGame();
                }
            }
        }

        private void ShowNextQuestion()
        {
            lblQuestion.Text = questions[currentQuestionIndex, 0];
            txtAnswer.Clear();
            lblResult.Text = "";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void RestartGame()
        {
            currentQuestionIndex = 0;
            correctAnswers = 0;
            attemptCount = 0;
            totalAttempts = 0;
            history.Clear();
            lblEndMessage.Visible = false;
            lblScore.Text = "Рахунок: 0";
            lblTotalAttempts.Text = "Загальна кількість спроб: 0";
            ShowNextQuestion();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("Ви впевнені, що хочете вийти?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}


