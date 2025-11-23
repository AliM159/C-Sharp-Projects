namespace Premier
{
    public partial class OntarioPremier : Form
    {

        Dictionary<string, Premier> premiers;
        public OntarioPremier()
        {
            InitializeComponent();
            InitializeGui();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void InitializeGui()
        {
            premiers = new Dictionary<string, Premier>();

            List<Premier> premierList = Premier.GetPremiers();
            foreach (Premier premier in premierList)
            {
                string key = premier.GenerateKey();
                if (!premiers.ContainsKey(key))
                {
                    premiers.Add(key, premier);
                }
            }

            lstPremiers.DataSource = premiers.Keys.ToList();
            lstPremiers.SelectedIndexChanged += LstPremiers_SelectedIndexChanged;
        }

        private void LstPremiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPremiers.SelectedItem != null)
            {
                string key = lstPremiers.SelectedItem.ToString();
                UpdateGui(key);
            }
        }
        
        private void UpdateGui(string key)
        {
            if (premiers.ContainsKey(key))
            {
                Premier selectedPremier = premiers[key];

                lbName.Text = selectedPremier.Name;
                lbLife.Text = selectedPremier.Life;
                lbTerm.Text = $"{selectedPremier.Start} - {selectedPremier.End}";

                string imagePath = Path.Combine("images", key + ".jpg");
                if (File.Exists(imagePath))
                {
                    picPremier.Image = Image.FromFile(imagePath);
                    picPremier.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    picPremier.Image = null;
                    MessageBox.Show($"Image not found: {imagePath}");
                }
            }
        }
    }
}
