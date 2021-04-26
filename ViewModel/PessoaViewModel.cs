using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using treino_notify.Command;
using treino_notify.Model;

namespace treino_notify.ViewModel
{
    public class PessoaViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string nomePropriedade)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nomePropriedade));
        }

        public ObservableCollection<PessoaModel> Pessoa { get; set; }

        public List<PessoaModel> PessoaNotify { get; set; }

          


        public string Nome { get; set; }
        public int Cpf { get; set; }

        public ICommand CreatePessoaCommand { get; private set; }
        public ICommand CreatePessoaNotifyCommand { get; private set; }
        public ICommand AlteraNomeCommand { get; private set; }

        public PessoaViewModel()
        {
            Nome = "String Inicial";

            Pessoa = new ObservableCollection<PessoaModel>();
            PessoaNotify = new List<PessoaModel>();
            
            this.MyCommands();
        }

        private void MyCommands()
        {
            AlteraNomeCommand = new RelayCommand(AlteraNome);
            CreatePessoaCommand = new RelayCommand(CreatePessoa);
            CreatePessoaNotifyCommand = new RelayCommand(CreatePessoaNotify);

        }

        public void AlteraNome(object objRelayCommand)
        {
            Nome = "Maria";
            OnPropertyChanged("Nome");
        }
        public void CreatePessoa(object objRelayCommand)
        {
            Pessoa.Add(new PessoaModel("João", 123));
        }
        public void CreatePessoaNotify(object objRelayCommand)
        {
            PessoaNotify.Add(new PessoaModel("Maria", 456));
            PessoaNotify = new List<PessoaModel>(PessoaNotify);
            OnPropertyChanged("PessoaNotify");
            
        }
    }
}
