using System;
using System.Collections.Generic;
using System.Text;

namespace Pagarme.Modelo
{
    enum StatusPagamento
    {
        Nenhum = 0,
        Aguardando = 1,
        Recusado = 2,
        Autorizado = 3,
        Pago = 4,
        Processando = 5,
        Estornado = 6,
        AguardandoEstorno = 7,
        Analise = 8,
        Pendente = 9
    }
}
