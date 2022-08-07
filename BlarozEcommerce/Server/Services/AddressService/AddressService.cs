namespace BlarozEcommerce.Server.Services.AddressService
{
    public class AddressService : IAddressService
    {
        private readonly DataContext _context;
        private readonly IAuthService _authService;

        public AddressService(DataContext context, IAuthService authService)
        {
            _context = context;
            _authService = authService;
        }

        public async Task<ServiceResponse<Address>> AddOrUpdateAddress(Address address)
        {
            var response = new ServiceResponse<Address>();
            var dbAdress = (await GetAddress()).Data;
            if (dbAdress == null)
            {
                address.UserId = _authService.GetUserId();
                _context.Addresses.Add(address);
                response.Data = address;
            }
            else
            {
                dbAdress.FirstName = address.FirstName;
                dbAdress.LastName = address.LastName;
                dbAdress.State = address.State;
                dbAdress.Country = address.Country;
                dbAdress.City = address.City;
                dbAdress.Zip = address.Zip;
                dbAdress.Street = address.Street;
                response.Data = dbAdress;
            }

            await _context.SaveChangesAsync();

            return response;
        }

        public async Task<ServiceResponse<Address>> GetAddress()
        {
            int userId = _authService.GetUserId();
            var address = await _context.Addresses.FirstOrDefaultAsync(a => a.UserId == userId);
            return new ServiceResponse<Address> { Data = address };
        }
    }
}
