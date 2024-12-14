using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QL_PhanQuyenDAL
    {
        private readonly DBDataContext db;

        public QL_PhanQuyenDAL()
        {
            db = new DBDataContext();
        }

        public List<QL_PhanQuyen> GetAllQL_PhanQuyens()
        {
            return db.QL_PhanQuyens.ToList();
        }

        public List<QL_PhanQuyen> getAllQl_PhanquyensByIdPosition(int idPosition)
        {
            List<QL_PhanQuyen> QlPQ = db.QL_PhanQuyens.Where(pq => pq.IDPositions == idPosition).ToList();
            return QlPQ;
        }
        public void AddQL_PhanQuyen(QL_PhanQuyen phanQuyen)
        {
            db.QL_PhanQuyens.InsertOnSubmit(phanQuyen);
            db.SubmitChanges();
        }

        public bool UpdatePermissionsByIdPosition(int positionId, List<QL_PhanQuyen> permissions)
        {
            try
            {
                var oldPermissions = db.QL_PhanQuyens.Where(p => p.IDPositions == positionId);
                db.QL_PhanQuyens.DeleteAllOnSubmit(oldPermissions);
                db.QL_PhanQuyens.InsertAllOnSubmit(permissions);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public void UpdateQL_PhanQuyen(QL_PhanQuyen phanQuyen)
        {
            var existingPhanQuyen = db.QL_PhanQuyens.SingleOrDefault(q => q.IDPositions == phanQuyen.IDPositions && q.ScreenCode == phanQuyen.ScreenCode);
            if (existingPhanQuyen != null)
            {
                existingPhanQuyen.HasPermission = phanQuyen.HasPermission;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("QL_PhanQuyen not found");
            }
        }

        public void DeleteQL_PhanQuyen(int positionId, string screenCode)
        {
            var phanQuyen = db.QL_PhanQuyens.SingleOrDefault(q => q.IDPositions == positionId && q.ScreenCode == screenCode);
            if (phanQuyen != null)
            {
                db.QL_PhanQuyens.DeleteOnSubmit(phanQuyen);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("QL_PhanQuyen not found");
            }
        }
    }
}
