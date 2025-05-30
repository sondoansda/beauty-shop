using beauty_shop.DAL;
using beauty_shop.Model;

namespace beauty_shop.BLL
{
    public class SanPhamBLL
    {
        private readonly SanPhamDAL _dal;

        public SanPhamBLL(SanPhamDAL dal)
        {
            _dal = dal;
        }

        public List<SanPhamDTO> GetAllSanPham()
        {
            try
            {
                return _dal.GetAllSanPham();
            }
            catch (Exception ex)
            {
                throw new Exception("Business layer error: " + ex.Message, ex);
            }
        }

        public void SaveOrUpdateSanPham(SanPhamDTO product, string imagePath)
        {
            try
            {
                _dal.SaveOrUpdateSanPham(product, imagePath);
            }
            catch (Exception ex)
            {
                throw new Exception("Business layer error: " + ex.Message, ex);
            }
        }

        public void DeleteSanPham(string maHang)
        {
            try
            {
                _dal.DeleteSanPham(maHang);
            }
            catch (Exception ex)
            {
                throw new Exception("Business layer error: " + ex.Message, ex);
            }
        }
    }
}