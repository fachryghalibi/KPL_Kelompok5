namespace APITelkomMedika;
public class APITelkomMedikaa
{
    public string Nama { get; set; }
    public string NIM { get; set; }
    public string Hari { get; set; }
    public string Jam { get; set; }

    public APITelkomMedikaa(string Nama, string NIM, string Hari, string Jam)
    {
        this.Nama = Nama;
        this.NIM = NIM;
        this.Hari = Hari;
        this.Jam = Jam;
    }
}