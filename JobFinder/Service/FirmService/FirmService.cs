using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.Model;
using JobFinder.Model.Utils;
using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils.Fetching.Filters;

namespace JobFinder.Service
{
    public class FirmService(IFirmRepository _firmRepository, IMapper _mapper) : IFirmService
    {
        public async Task<CreateFirmResponseModel> CreateFirmAsync(CreateFirmModel firm)
        {
            var firmEntity = _mapper.Map<Firm>(firm);
            var entity = await _firmRepository.AddAsync(firmEntity);
            return _mapper.Map<CreateFirmResponseModel>(entity);
        }
        public async Task<ListResponseModel<FirmModel>> GetAllFirmAsync(FirmFilter filter, Order order, Pagination pagination)
        {

            var entities = await _firmRepository.GetAllAsListModelAsync(filter, order, pagination);
            var result = new ListResponseModel<FirmModel>
            {
                Data = _mapper.Map<List<FirmModel>>(entities.Data),
                Total = entities.Total,
                Pagination = pagination
            };
            return result;
        }
        public async Task<FirmModel> GetFirmAsync(Guid id)
        {
            var entity = await _firmRepository.GetAsync(id);
            return _mapper.Map<FirmModel>(entity);
        }
        public async Task<UpdateFirmReponseModel> UpdateFirmAsync(Guid id, UpdateFirmModel newFirmModel)
        {
            Firm currentFirm = await _firmRepository.GetAsync(id);
            if (currentFirm == null)
            {
                throw new Exception("Firm not found");
            }
            //Update only changed properties
            {

                if (!string.IsNullOrEmpty(newFirmModel.EmailContact))
                {
                    currentFirm.EmailContact = newFirmModel.EmailContact;
                }
                if (!string.IsNullOrEmpty(newFirmModel.PhoneContact))
                {
                    currentFirm.PhoneContact = newFirmModel.PhoneContact;
                }
                if (!string.IsNullOrEmpty(newFirmModel.Address))
                {
                    currentFirm.Address = newFirmModel.Address;
                }
                if (!string.IsNullOrEmpty(newFirmModel.Website))
                {
                    currentFirm.Website = newFirmModel.Website;
                }
            }
            var res = await _firmRepository.UpdateAsync(currentFirm);
            return _mapper.Map<UpdateFirmReponseModel>(res);
        }
        public async Task<List<PositionModel>> GetFirmPositions(Guid id, PositionFilter filter, Order order, Pagination pagination)
        {
            var positions = await _firmRepository.GetFirmPositions(id, filter, order, pagination);
            return _mapper.Map<List<PositionModel>>(positions);
        }
    }
}
