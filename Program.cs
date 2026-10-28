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

            IUserRepository userRepo = new UserRepository();
            IEquipmentRepository equipmentRepo = new EquipmentRepository();
            IRequestRepository requestRepo = new RequestRepository();

            IAuthService authService = new AuthService(userRepo);
            IEquipmentService equipmentService = new EquipmentService(equipmentRepo);
            IRequestService requestService = new RequestService(requestRepo);

            Application.Run(new LogIn(authService, equipmentService, requestService));
        }
    }
}
