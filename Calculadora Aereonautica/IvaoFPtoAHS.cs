
namespace Calculadora_Aereonautica_
{
    public partial class IvaoFPtoAHS : Form
    {
        private string configFilePath = @"config.txt";
        private string baseSaveDirectory;
        private string lastOpenDirectory;

        public IvaoFPtoAHS()
        {
            InitializeComponent();
            LoadConfiguration();
        }
        private void Seleccionar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = lastOpenDirectory ?? Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                openFileDialog.Filter = "FPL files (*.fpl)|*.fpl|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    lastOpenDirectory = Path.GetDirectoryName(openFileDialog.FileName);
                    SaveConfiguration();
                    string filePath = openFileDialog.FileName;
                    ProcessFile(filePath);
                }
            }
        }
        private void Destino_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.SelectedPath = baseSaveDirectory ?? Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    baseSaveDirectory = folderBrowserDialog.SelectedPath;
                    SaveConfiguration();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void ProcessFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                string rules = GetValueFromLine(lines, "RULES=");
                string number = GetValueFromLine(lines, "NUMBER=");
                string wakeCat = GetValueFromLine(lines, "WAKECAT=");
                string equipment = GetValueFromLine(lines, "EQUIPMENT=");
                string speed = GetValueFromLine(lines, "SPEED=");
                string depicao = GetValueFromLine(lines, "DEPICAO=");
                string deptime = GetValueFromLine(lines, "DEPTIME=");
                string level = GetValueFromLine(lines, "LEVEL=");
                level = "F" + level;
                string desticao = GetValueFromLine(lines, "DESTICAO=");
                string eet = GetValueFromLine(lines, "EET=");
                string endurance = GetValueFromLine(lines, "ENDURANCE=");
                string alticao = GetValueFromLine(lines, "ALTICAO=");
                string other = GetValueFromLine(lines, "OTHER=");
                string route = GetValueFromLine(lines, "ROUTE=");
                string flighttype = GetValueFromLine(lines, "FLIGHTTYPE=");
                string pob = GetValueFromLine(lines, "POB=");
                string alticao2 = GetValueFromLine(lines, "ALTICAO2=");

                string[] outputLines = new string[19];
                outputLines[0] = rules ?? string.Empty;
                outputLines[1] = number ?? string.Empty;
                outputLines[2] = string.Empty;
                outputLines[3] = wakeCat ?? string.Empty;
                outputLines[4] = equipment ?? string.Empty;
                outputLines[5] = "S";
                outputLines[6] = speed ?? string.Empty;
                outputLines[7] = depicao ?? string.Empty;
                outputLines[8] = deptime ?? string.Empty;
                outputLines[9] = level ?? string.Empty;
                outputLines[10] = desticao ?? string.Empty;
                outputLines[11] = eet ?? string.Empty;
                outputLines[12] = endurance ?? string.Empty;
                outputLines[13] = alticao ?? string.Empty;
                outputLines[14] = other ?? string.Empty;
                outputLines[15] = route ?? string.Empty;
                outputLines[16] = flighttype ?? string.Empty;
                outputLines[17] = pob ?? string.Empty;
                outputLines[18] = alticao2 ?? string.Empty;

                string outputFilePath = Path.Combine(baseSaveDirectory, Path.GetFileNameWithoutExtension(filePath) + ".plan");
                File.WriteAllLines(outputFilePath, outputLines);

                MessageBox.Show($"File processed and saved as {outputFilePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetValueFromLine(string[] lines, string prefix)
        {
            return lines.FirstOrDefault(line => line.StartsWith(prefix))?.Substring(prefix.Length).Trim();
        }
        private void LoadConfiguration()
        {
            if (File.Exists(configFilePath))
            {
                string[] configLines = File.ReadAllLines(configFilePath);
                if (configLines.Length >= 2)
                {
                    lastOpenDirectory = configLines[0];
                    baseSaveDirectory = configLines[1];
                }
            }
            else
            {
                SetInitialDirectories();
            }
        }
        private void SaveConfiguration()
        {
            File.WriteAllLines(configFilePath, new[] { lastOpenDirectory, baseSaveDirectory });
        }
        private void SetInitialDirectories()
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Seleccionar origen de datos";
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    lastOpenDirectory = folderBrowserDialog.SelectedPath;
                }
            }

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Seleccionar directorio de destino";
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    baseSaveDirectory = folderBrowserDialog.SelectedPath;
                }
            }

            SaveConfiguration();
        }
        private void IvaoFPtoAHS_Load(object sender, EventArgs e)
        {

        }
    }
}
