using System;
using System.Threading; 
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymulatorMiasta
{
    public partial class Form1 : Form
    {
        private Random _random = new Random();
        private TaskCompletionSource<bool> _waitForFix; // obs³uga zdarzenia losowego

        private SemaphoreSlim _uiLock = new SemaphoreSlim(1, 1); //kolejkowanie zdarzeñ

        private DateTime _lastActivity = DateTime.Now;
        private bool _isWaitingForPresence = false; // obs³uga nieaktywnoœci operatora
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.label8.Hide();
            this.label9.Hide();
            this.Naprawa.Hide();
            this.ZadowolenieLudu.Value = 50;
            this.BackgroundImage = Properties.Resources.tlo;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Skryba.Image = Properties.Resources.skryba;
            this.Skryba.SizeMode = PictureBoxSizeMode.StretchImage;
            this.wladca.Image = Properties.Resources.wladca;
            this.wladca.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureLud.Image = Properties.Resources.lud;
            this.pictureLud.SizeMode = PictureBoxSizeMode.StretchImage;
            this.label1.Text = "Rozpocznij zbiory";
            this.label2.Text = "Zbierz podatki";
            this.label3.Text = "Rozpocznij negocjacje";
            this.label4.Text = "Zadowolenie ludu";
            this.label5.Text = "Zbiory";
            this.label6.Text = "Podatki";
            this.label7.Text = "Negocjacje";
            label9.MaximumSize = new Size(250, 0);
            label9.AutoSize = true;
            _ = SprawdzajObecnosc();
        }
        private void ResetActivity()
        {
            _lastActivity = DateTime.Now;
        }
        private async Task SprawdzajObecnosc()
        {
            while (true)
            {
                await Task.Delay(5000);
                if(!_isWaitingForPresence && (DateTime.Now - _lastActivity).TotalMinutes >=1)
                {
                    await ObsluzZdarzenie(async () =>
                    {
                        _isWaitingForPresence = true;
                        label9.Text = "Œpisz Panie? (Wciœnij 'E')";
                        label9.Show();
                        _waitForFix = new TaskCompletionSource<bool>();
                        await _waitForFix.Task;
                        _isWaitingForPresence = false;
                        ResetActivity();
                    });
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (_isWaitingForPresence && e.KeyCode == Keys.E)
            {
                if (_waitForFix != null && !_waitForFix.Task.IsCompleted)
                {
                    _waitForFix.TrySetResult(true);
                }
            }
        }
        private async Task ObsluzZdarzenie(Func<Task> akcjaZdarzenia)
        {
            await _uiLock.WaitAsync();
            try
            {
                await akcjaZdarzenia();
            }
            finally
            {
                label9.Hide();
                Naprawa.Hide();
                _uiLock.Release();
            }
        }

        private void ZbioryButton_MouseHover(object sender, EventArgs e)
        {
            this.label8.Text = "po wciœniêciu rozpoczn¹ siê zbiory";
            this.label8.Show();
        }

        private void PodatkiButton_MouseHover(object sender, EventArgs e)
        {
            this.label8.Text = "po wciœniêciu rozpocznie siê zbieranie podatków";
            this.label8.Show();
        }

        private void NegocjujButton_MouseHover(object sender, EventArgs e)
        {
            this.label8.Text = "po wciœniêciu rozpoczn¹ siê negocjacje";
            this.label8.Show();
        }
        private void Guizk_MouseLeave(object sender, EventArgs e)
        {
            this.label8.Hide();
        }

        private async void ZbioryButton_Click(object sender, EventArgs e)
        {
            ResetActivity();
            ZbioryButton.Enabled = false;
            ProgresZbiorow.Value = 0;
            for (int i = 0; i <= 100; i++)
            {
                ProgresZbiorow.Value = i;
                if (_random.Next(0, 100) < 2 && i > 5)
                {
                    await ObsluzZdarzenie(async () =>
                    {
                        label9.Show();
                        label9.Text = "PANIE! Ch³opy siê zbuntowa³y!";
                        Naprawa.Text = "Sch³ostaj ch³opów";
                        Naprawa.Enabled = true;
                        Naprawa.Show();
                        _waitForFix = new TaskCompletionSource<bool>();
                        await _waitForFix.Task;
                    });
                }
                if (ZadowolenieLudu.Value == 0)
                {
                    await ObsluzZdarzenie(async () =>
                    {
                        label9.Text = "PANIE! Lud wszczyna rebeliê z powodu tyranii!";
                        label9.Show();
                        Naprawa.Text = "Pojmij rebeliantów";
                        Naprawa.Enabled = true;
                        Naprawa.Show();
                        _waitForFix = new TaskCompletionSource<bool>();
                        await _waitForFix.Task;
                        ZadowolenieLudu.Value = 30;
                    });
                }
                if (ProgresZbiorow.Value == 100)
                {
                    ZadowolenieLudu.Value += 20;
                    ProgresZbiorow.Value = 0;
                    ZbioryButton.Enabled = true;
                }
                await Task.Delay(50);
            }
        }

        private async void PodatkiButton_Click(object sender, EventArgs e)
        {
            ResetActivity();
            PodatkiButton.Enabled = false;
            progresPodatki.Value = 0;
            for (int i = 0; i <= 100; i++)
            {
                progresPodatki.Value = i;
                if (_random.Next(0, 100) < 2 && i > 5)
                {
                    await ObsluzZdarzenie(async () =>
                    {
                        label9.Show();
                        label9.Text = "PANIE! Mieszczanie maj¹ doœæ podatków!";
                        Naprawa.Text = "Wyœlij wojsko";
                        Naprawa.Enabled = true;
                        Naprawa.Show();
                        _waitForFix = new TaskCompletionSource<bool>();
                        await _waitForFix.Task;
                    });
                }
                if (ZadowolenieLudu.Value == 0)
                {
                    await ObsluzZdarzenie(async () =>
                    {
                        label9.Text = "PANIE! Lud wszczyna rebeliê z powodu tyranii!";
                        label9.Show();
                        Naprawa.Text = "Pojmij rebeliantów";
                        Naprawa.Enabled = true;
                        Naprawa.Show();
                        _waitForFix = new TaskCompletionSource<bool>();
                        await _waitForFix.Task;
                        ZadowolenieLudu.Value = 30;
                    });
                }
                if (progresPodatki.Value == 100)
                {
                    ZadowolenieLudu.Value += 20;
                    progresPodatki.Value = 0;
                    ZbioryButton.Enabled = true;
                }
                await Task.Delay(50);
            }

        }

        private async void NegocjujButton_Click(object sender, EventArgs e)
        {
            ResetActivity();
            NegocjujButton.Enabled = false;
            progresNegocjacje.Value = 0;
            for (int i = 0; i <= 100; i++)
            {
                progresNegocjacje.Value = i;
                if (_random.Next(0, 100) < 10 && i > 5)
                {
                    await ObsluzZdarzenie(async () =>
                    {
                        label9.Show();
                        label9.Text = "PANIE! Negocjacje nie id¹ po naszej myœli!";
                        Naprawa.Text = "Wydaj córkê za m¹¿";
                        Naprawa.Enabled = true;
                        Naprawa.Show();
                        _waitForFix = new TaskCompletionSource<bool>();
                        await _waitForFix.Task;
                    });
                }
                if (ZadowolenieLudu.Value == 0)
                {
                    await ObsluzZdarzenie(async () =>
                    {
                        label9.Text = "PANIE! Lud wszczyna rebeliê z powodu tyranii!";
                        label9.Show();
                        Naprawa.Text = "Pojmij rebeliantów";
                        Naprawa.Enabled = true;
                        Naprawa.Show();
                        _waitForFix = new TaskCompletionSource<bool>();
                        await _waitForFix.Task;
                        ZadowolenieLudu.Value = 30;
                    });
                }
                if (progresNegocjacje.Value == 100)
                {
                    ZadowolenieLudu.Value += 20;
                    progresNegocjacje.Value = 0;
                    NegocjujButton.Enabled = true;
                }
                await Task.Delay(50);
            }

        }
        private void Naprawa_Click(object sender, EventArgs e)
        {
            Naprawa.Enabled = false;
            if (ZadowolenieLudu.Value >= 10)
            {
                ZadowolenieLudu.Value -= 10;
            }
            else
            {
                ZadowolenieLudu.Value = 0;
            }
            if (_waitForFix != null && !_waitForFix.Task.IsCompleted)
            {
                _waitForFix.TrySetResult(true);
            }
        }
    }
}