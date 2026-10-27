namespace Composite
{
    //Component
    public abstract class Funcionario
    {
        public string Nome { get; set; }

        public Funcionario(string nome) { Nome = nome; }

        public abstract string Operation();

        public virtual void Add(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public virtual Funcionario Get(int index)
        {
            throw new NotImplementedException();
        }
    }
}
