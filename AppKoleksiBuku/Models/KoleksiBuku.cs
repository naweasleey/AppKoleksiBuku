namespace AppKoleksiBuku.Models
{
    public class KoleksiBuku
    {
        public Buku Buku { get; set; }

        public KoleksiBuku(Buku buku)
        {
            Buku = buku;
        }
    }
}
