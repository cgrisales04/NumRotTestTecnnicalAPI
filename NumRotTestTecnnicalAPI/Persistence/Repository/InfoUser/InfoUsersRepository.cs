using Microsoft.EntityFrameworkCore;
using NumRotTestTecnnicalAPI.Persistence.Entity;
using NumRotTestTecnnicalAPI.Persistence.Repository.RepositoryBase;

namespace NumRotTestTecnnicalAPI.Persistence.Repository.InfoUser {
    public class InfoUsersRepository : RepositoryBase<InfoUsers>, IInfoUsersRepository {
        public InfoUsersRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

        public IEnumerable<InfoUsers> GetAllInfoUsers() {
            return FindAll()
                .Include(ac => ac.Gender)
                .Include(ac => ac.TypeUser)
                .ToList();
        }

        public void CreateInfoUsers(InfoUsers infoUser) {
            Create(infoUser);
        }

        public void DeleteInfoUsers(InfoUsers infoUser) {
            Delete(infoUser);
        }

        public void UpdateInfoUsers(InfoUsers infoUser) {
            Update(infoUser);
        }

        public InfoUsers GetInfoUsersById(int id) {
            return FindByCondition(info_user => info_user.info_user_id.Equals(id))
                .Include(ac => ac.Gender)
                .Include(ac => ac.TypeUser)
                .FirstOrDefault();
        }

        public InfoUsers GetInfoUsersByIdNotJoin(int id) {
            return FindByCondition(info_user => info_user.info_user_id.Equals(id))
                .FirstOrDefault();
        }

        public InfoUsers GetInfoUsersByIdentification(string identification) {
            return FindByCondition(info_user => info_user.identification.Equals(identification))
                .FirstOrDefault();
        }

    }
}
