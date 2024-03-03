Console.WriteLine("Hello, World!");
private void buttonSubmit_Click(object sender, EventArgs e)
{
    // Membaca teks dari TextBox input
    string inputText = textBoxInput.Text;

    // Memeriksa apakah inputText adalah "NAMA_PRAKTIKAN"
    if (inputText.Equals("NAMA_PRAKTIKAN"))
    {
        // Menetapkan teks label output
        labelOutput.Text = "Halo NAMA_PRAKTIKAN";
    }
    else
    {
        // Jika input tidak sesuai, menetapkan teks label output ke pesan error
        labelOutput.Text = "Input tidak valid!";
    }
}
