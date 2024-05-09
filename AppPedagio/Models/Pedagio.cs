using SQLite;

namespace AppPedagio.Models
{
    public class Pedagio
    {
        public string _Origem;
        public string _Destino;
        public string Local;
        public double Valor;
        public double _Distancia;
        public double _Rendimento;
        public double _Precogas;

        public string Origem 
        {
            get => Origem;
            set
            {
                if (value == null)
                    throw new Exception("Origem inválida.");

                Origem = value;
            }
        }

        public string Destino
        {
            get => _Destino;
            set
            {
                if (value == null)
                    throw new Exception("Destino incorreto.");

                _Destino = value;
            }
        }

        public double Distancia
        {
            get
            {
                return _Distancia;
            }

            set
            {
                if (!double.TryParse(value.ToString(), out _Distancia))
                    _Distancia = 0;

                if (value == 0)
                    throw new Exception("Opção inválida.");

                _Distancia = value;
            }
        }

        public double Rendimento
        {
            get
            {
                return _Rendimento;
            }

            set
            {
                if (!double.TryParse(value.ToString(), out _Rendimento))
                    _Rendimento = 0;

                if (value == 0)
                    throw new Exception("Opção inválida.");

                _Rendimento = value;
            }
        }

        public double Precogas
        {
            get
            {
                return _Precogas;
            }

            set
            {
                if (!double.TryParse(value.ToString(), out _Precogas))
                    _Precogas = 0.0;

                if (value == 0)
                    throw new Exception("Preço inválido.");

                _Precogas = value;
            }
        }
    }
}
