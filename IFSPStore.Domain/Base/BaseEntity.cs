
namespace IFSPStore.Domain.Base
{
    //clase abstract não pode ser instânciada
    public abstract class BaseEntity<TID> : IBaseEntity//consigo mudar sem alterar o codigo
    {
        protected BaseEntity() 
        {
        }

        protected BaseEntity(TID id) //construtor 
        {
            Id = id;
        }
        public TID? Id { get; set; }//toda vez que herdar a class vai ter id
    }
}
