using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace treino_notify.Model
{
    public class PessoaModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string nomePropriedade)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nomePropriedade));
        }

        public PessoaModel(string mdlNome, int mdlCPF)
        {
            Nome = mdlNome;
            Cpf = mdlCPF;
        }

        private string _nome;
        private int _cpf;

        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
                OnPropertyChanged("Nome");
            }
        }

        public int Cpf
        {
            get { return _cpf; }
            set
            {
                _cpf = value;
                OnPropertyChanged("Cpf");
            }
        }

    }
}