namespace DapperCRUDApplication.Settings
{
    public interface IDatabaseSettings
    {
        public string CompanyCollectionName { get; set; }//company tablo adı parametresi
        public string EmployeeCollectionName { get; set; }//employee tablosu adı parametresi
        public string ConnectionString { get; set; }//veritabanı bağlantı adresi
        public string DatabaseName { get; set; }//veritabanı adı
    }
}
