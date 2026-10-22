using SanaPass_EBAAMS.DataRepo;
using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanaPass_EBAAMS
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Initialize Repositories
            IUserRepository userRepo = new UserRepository();
            IEquipmentRepository equipmentRepo = new EquipmentRepository();
            IRequestRepository requestRepo = new RequestRepository();

            // 2. Initialize Application Services
            IAuthService authService = new AuthService(userRepo);
            IEquipmentService equipmentService = new EquipmentService(equipmentRepo);
            IRequestService requestService = new RequestService(requestRepo);

            // 3. Launch LogIn Form with dependencies
            Application.Run(new LogIn(authService, equipmentService, requestService));
        }
    }
}
