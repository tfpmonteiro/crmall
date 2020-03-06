using Dapper.FluentMap;

namespace crmall.Repository.Map
{
    public class ConfigMapDapper
    {
        private static bool _carregado;

        public static void Carregar()
        {
            if (_carregado) return;

            FluentMapper.Initialize(config =>
            {
                //config.AddMap(null);
                //config.ForDommel();
            });

            _carregado = true;
        }
    }
}
