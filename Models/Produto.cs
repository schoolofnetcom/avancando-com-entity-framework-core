namespace asp_net_e_entity_framework_master.Models
{
    public class Produto
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public virtual Categoria Categoria {get; set;}

        public override string ToString(){
            return "Id: " + this.Id + " Nome: " + this.Nome + " Categoria: [" + this.Categoria.ToString() + "] ";
        }
    }
}