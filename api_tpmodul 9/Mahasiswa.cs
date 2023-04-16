namespace api_tpmodul_9
{
    public class Mahasiswa
    {
        private string Nama { get; set; }
        private string Nim { get; set; }

        public Mahasiswa(string Nama, string Nim)
        {
            this.Nama = Nama;
            this.Nim = Nim;
        }
    }
}
