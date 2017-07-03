using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            Imposto iss = new ISS();
            Imposto icms = new ICMS();
            Imposto iccc = new ICCC();
            Imposto ikcv = new IKCV();
            Imposto icpp = new ICPP();
            Imposto ihit = new IHIT();
            Imposto iAlto = new ImpostoAlto();

            Imposto issComposto = new ISS(new ICMS(new ICCC()));

            Conta conta = new Conta(600, "Fulano de Tal");

            conta.StatusAtual.Depositar(conta, 150);
            Console.WriteLine("Saldo = " + conta.Saldo);

            conta.StatusAtual.Sacar(conta, 1000);
            Console.WriteLine("Saldo = " + conta.Saldo);

            conta.StatusAtual.Sacar(conta, 150);
            Console.WriteLine("Saldo = " + conta.Saldo);

            conta.StatusAtual.Depositar(conta, 500);
            Console.WriteLine("Saldo = " + conta.Saldo);

            conta.StatusAtual.Sacar(conta, 150);
            Console.WriteLine("Saldo = " + conta.Saldo);

            Investimento investimento = new Arrojado();

            RealizadorInvestimentos realizarImposto = new RealizadorInvestimentos();
            realizarImposto.RealizarInvestimento(conta, investimento);

            Orcamento orcamento = new Orcamento(1000);

            orcamento.Itens.Add(new Item("ITEM 01", 100));
            orcamento.Itens.Add(new Item("ITEM", 230));
            orcamento.Itens.Add(new Item("ITEM12", 340));
            orcamento.Itens.Add(new Item("LAPIS", 121));
            orcamento.Itens.Add(new Item("CANETA", 1212));

            CalculadorImpostos calculador = new CalculadorImpostos();

            calculador.RealizarCalculo(orcamento, iss);
            calculador.RealizarCalculo(orcamento, icms);
            calculador.RealizarCalculo(orcamento, iccc);
            calculador.RealizarCalculo(orcamento, ikcv);
            calculador.RealizarCalculo(orcamento, icpp);
            calculador.RealizarCalculo(orcamento, ihit);
            calculador.RealizarCalculo(orcamento, issComposto);
            calculador.RealizarCalculo(orcamento, iAlto);

            AplicarDesconto aplicarDesconto = new AplicarDesconto();
            aplicarDesconto.CalcularDesconto(orcamento);


            Conta conta2 = new Conta(1200, "Outro Fulano");

            IList<Conta> contas = new List<Conta>();
            contas.Add(conta);
            contas.Add(conta2);

            RelatorioCompleto relatorioCompleto = new RelatorioCompleto();
            relatorioCompleto.Imprimir(contas);

            RelatorioSimplificado relatorioSimplificado = new RelatorioSimplificado();
            relatorioSimplificado.Imprimir(contas);


            Orcamento orc1 = new Orcamento(500);
            orc1.EstadoAtual.AplicarDescontoExtra(orc1);
            Console.WriteLine("ORC = " + orc1.Valor);

            orc1.EstadoAtual.Aprovar(orc1);
            orc1.EstadoAtual.AplicarDescontoExtra(orc1);
            Console.WriteLine("ORC = " + orc1.Valor);

            orc1.EstadoAtual.Finalizar(orc1);
            orc1.EstadoAtual.AplicarDescontoExtra(orc1);
            orc1.EstadoAtual.Reprovar(orc1);



            Console.ReadKey();
            

        }
    }
}
