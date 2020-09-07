using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._01_Creational._1._1_Abstract_Factory
{
    public class SocorroVeiculoGrandeFactoy : AutoSocorroFactory
    {
        public override Guincho CriarGuincho()
        {
            return GuinchoCreator.Criar(Porte.Grande);
        }

        public override Veiculo CriarVeiculo(string modelo, Porte porte)
        {
            return VeiculoCreator.Criar(modelo, porte);
        }
    }
}
