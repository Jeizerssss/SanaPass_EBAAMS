using SanaPass_EBAAMS.DataRepo;
using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Services;
using System;
using System.Windows.Forms;

namespace SanaPass_EBAAMS
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IDbConnectionFactory connectionFactory =
                new MySqlConnectionFactory();

            IUserRepository userRepository =
                new UserRepository(connectionFactory);

            IEquipmentRepository equipmentRepository =
                new EquipmentRepository(connectionFactory);

            IRequestRepository requestRepository =
                new RequestRepository(connectionFactory);

            IEmployeeRepository employeeRepository =
                new EmployeeRepository(connectionFactory);

            IFineRepository fineRepository =
                new FineRepository(connectionFactory);

            IPaymentHistoryRepository paymentHistoryRepository =
                new PaymentHistoryRepository(connectionFactory);

            ITransactionLogRepository transactionLogRepository =
                new TransactionLogRepository(connectionFactory);

            IMaintenanceRepository maintenanceRepository =
                new MaintenanceRepository(connectionFactory);

            ILocationRepository locationRepository =
                new LocationRepository(connectionFactory);

            ICategoryRepository categoryRepository =
                new CategoryRepository(connectionFactory);

            IUserService userService =
                new UserService(userRepository);

            IAuthService authService =
                new AuthService(userRepository);

            IEquipmentService equipmentService =
                new EquipmentService(equipmentRepository);

            IRequestService requestService =
                new RequestService(requestRepository, equipmentRepository);

            IReportService reportService =
                new ReportService(
                    requestRepository,
                    equipmentRepository,
                    maintenanceRepository,
                    categoryRepository);

            IFineService fineService =
                new FineService(
                    fineRepository,
                    requestRepository,
                    paymentHistoryRepository,
                    transactionLogRepository);

            IBorrowService borrowService =
                new BorrowService(
                    requestRepository,
                    equipmentRepository,
                    transactionLogRepository,
                    fineService,
                    maintenanceRepository);

            Application.Run(
                new LogIn(
                    authService,
                    equipmentService,
                    requestService,
                    employeeRepository,
                    reportService,
                    userService)
                    );
        }
    }
}
