using AspNetCoreHero.ToastNotification.Abstractions;
using Fintrak.TRMS.Models;
using Fintrak.TRMS.PageDTO;
using Fintrak.TRMS.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace Fintrak.TRMS.Controllers
{
    //[Authorize(AuthenticationSchemes = "ExternalApiBearer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TokenStorageService _tokenStorageService;
        private readonly INotyfService _notyf;
        IPendingApplicationRepository _pendingApplicationRepository;
        IProcessedApplicationRepository _processedApplicationRepository;
        IFormADetailsRepository _formADetailsRepository;
        IProcessedApplicationNCXRepository _processedApplicationNCXRepository;
        IPendingApplicationNCXRepository _pendingApplicationNCXRepository;
        IPendingFormNXPRepository _pendingFormNXPRepository;
        IProcessedNXPRepository _processedNXPRepository;
        INXPFormDetailsRepository _nXPFormDetailsRepository;
        ISingleShipmentRepository _singleShipmentRepository;
        IShipmentFormDetailsRepository _shipmentFormDetailsRepository;
        IApprovalRejectionRepository _approvalRejectionRepository;
        IDisbursementReviewerRepository _disbursementReviewerRepository;
        IADBReviewerRepository _adbReviewerRepository;
        IADBReviewerNCXRepository _adbReviewerNCXRepository;
        ICancelADBReviewerNCXRepository _cancelADBReviewerNCXRepository;

        public HomeController(ILogger<HomeController> logger, IPendingApplicationRepository pendingApplicationRepository,
            IProcessedApplicationRepository processedApplicationRepository, IFormADetailsRepository formADetailsRepository, 
            TokenStorageService tokenStorageService, IProcessedApplicationNCXRepository processedApplicationNCXRepository,
            IPendingApplicationNCXRepository pendingApplicationNCXRepository, IPendingFormNXPRepository pendingFormNXPRepository,
            IProcessedNXPRepository processedNXPRepository, INXPFormDetailsRepository nXPFormDetailsRepository, INotyfService notyf,
            ISingleShipmentRepository singleShipmentRepository, IShipmentFormDetailsRepository shipmentFormDetailsRepository,
            IApprovalRejectionRepository approvalRejectionRepository, IDisbursementReviewerRepository disbursementReviewerRepository, 
            IADBReviewerRepository adbReviewerRepository, IADBReviewerNCXRepository adbReviewerNCXRepository,
            ICancelADBReviewerNCXRepository cancelADBReviewerNCXRepository)
        {
            _logger = logger;
            _pendingApplicationRepository = pendingApplicationRepository;
            _processedApplicationRepository = processedApplicationRepository;
            _formADetailsRepository = formADetailsRepository;

            _tokenStorageService = tokenStorageService;
            _processedApplicationNCXRepository = processedApplicationNCXRepository;
            _pendingApplicationNCXRepository = pendingApplicationNCXRepository;

            _pendingFormNXPRepository = pendingFormNXPRepository;
            _processedNXPRepository = processedNXPRepository;
            _nXPFormDetailsRepository = nXPFormDetailsRepository;
            _singleShipmentRepository = singleShipmentRepository;
            _shipmentFormDetailsRepository = shipmentFormDetailsRepository;
            _approvalRejectionRepository = approvalRejectionRepository;
            _notyf = notyf;
            _disbursementReviewerRepository = disbursementReviewerRepository;
            _adbReviewerRepository = adbReviewerRepository;
            _adbReviewerNCXRepository = adbReviewerNCXRepository;
            _cancelADBReviewerNCXRepository = cancelADBReviewerNCXRepository;
        }

        public IActionResult Index(string applicationId = "")
        {
            //var token = _tokenStorageService.RetrieveToken();
            FormAPageDTO formAPageDTO = new FormAPageDTO();
            //formAPageDTO.PendingFormA = _pendingApplicationRepository.PendingApplication(applicationId, token).Result;
            //formAPageDTO.ProcessedFormA = _processedApplicationRepository.ProcessedApplication(applicationId, token).Result;
            return View(formAPageDTO);
        }

        public IActionResult FormNCX(string applicationId = "")
        {
            //var token = _tokenStorageService.RetrieveToken();
            FormNCXPageDTO formNCXPageDTO = new FormNCXPageDTO();
            //formNCXPageDTO.PendingFormNCX = _pendingApplicationNCXRepository.PendingApplicationNCX(applicationId, token).Result;
            //formNCXPageDTO.ProcessedFormNCX = _processedApplicationNCXRepository.ProcessedApplicationNCX(applicationId, token).Result;
            return View(formNCXPageDTO);
        }

        public IActionResult FormNXP(string applicationId = "")
        {
            //var token = _tokenStorageService.RetrieveToken();
            FormNXPPageDTO formNXPPageDTO = new FormNXPPageDTO();
            //formNXPPageDTO.PendingFormNXP = _pendingFormNXPRepository.GetPendingFormNXP(applicationId, token).Result;
            //formNXPPageDTO.ProcessedFormNXP = _processedNXPRepository.GetProcessedNXP(applicationId, token).Result;

            //formNXPPageDTO.FormNXPDetail = _nXPFormDetailsRepository.GetNXPFormDetails(applicationId, token).Result;
            //formNXPPageDTO.NXPShipments = _singleShipmentRepository.GetSingleShipment(applicationId, token).Result;
            //formNXPPageDTO.ShipmentFormDetail = _shipmentFormDetailsRepository.GetShipmentFormDetails(applicationId, token).Result;
            return View(formNXPPageDTO);
        }

        public IActionResult FormADetails(string applicationId)
        {
            //var token = _tokenStorageService.RetrieveToken();
            FormADetailsPageDTO details = new FormADetailsPageDTO();
            //details = _formADetailsRepository.GetFormADetails(applicationId, token).Result; // Replace with your actual details retrieval logic
            return View(details); // Assuming _Details.cshtml is your details view
        }

        [HttpPost]
        public IActionResult ApprovalFormA (ApprovalRejectionRequest approvalFormA, string applicationId, string ADB)
        {
            try
            {
                string response = "";
                //var token = _tokenStorageService.RetrieveToken();
                if (ADB == "no")
                {
                    response = _approvalRejectionRepository.ApprovalRejection(approvalFormA, applicationId, "ghvghvghn").Result.ResponseResult;
                }
                else
                {
                    ADBReviewerRequest cancelRequest = new ADBReviewerRequest();
                    cancelRequest.Approved = approvalFormA.Approved;
                    cancelRequest.DaemonReviewName = approvalFormA.DaemonReviewerName;
                    cancelRequest.Note = approvalFormA.Note;
                    cancelRequest.RejectionReasonCode = approvalFormA.RejectionReasonCode;
                    cancelRequest.DaemonSupervisorName = approvalFormA.DaemonSupervisorName;
                    response = _adbReviewerRepository.ADBReviewer(cancelRequest, applicationId, "ghvghvghn").Result.ResponseResult;
                }
                _notyf.Error("Fintrak | " + response);
                return RedirectToAction("FormADetails", new { applicationId = applicationId });
            }
            catch (Exception ex)
            {
                string innerMessage = ex.InnerException.Message;

                if (int.TryParse(innerMessage, out int statusCode))
                {
                    object responseModel = ex.InnerException.InnerException.Message.ToString();
                    _notyf.Error(statusCode + " | " + responseModel);
                }
                else
                {
                    _notyf.Error(500 + " | " + ex.InnerException.Message);
                }
            }
            return RedirectToAction("FormADetails", new { applicationId = applicationId });
        }

        [HttpPost]
        public IActionResult DisbursementFormA(DisbursementReviewerRequest disbursement, string applicationId, string reasonCode)
        {
            try
            {
                string response = "";
                //var token = _tokenStorageService.RetrieveToken();
                if (disbursement.RejectionStakeholder == "Approved")
                {
                    disbursement.Approved = true;
                    disbursement.RejectionStakeholder = null;
                    response = _disbursementReviewerRepository.DisbursementReviewer(disbursement, applicationId, "ghvghvghn").Result.ResponseResult;
                }
                else
                {
                    RejectDisbursementRequest rejectDisbursement = new RejectDisbursementRequest();
                    rejectDisbursement.Note = disbursement.Note;
                    rejectDisbursement.DisbursementsCloseOut = true;
                    rejectDisbursement.RejectionStakeholder = disbursement.RejectionStakeholder;
                    rejectDisbursement.RejectionReasonCode = reasonCode;
                    response = _disbursementReviewerRepository.RejectDisbursement(rejectDisbursement, applicationId, "ghvghvghn").Result.ResponseResult;
                }
                _notyf.Success("Fintrak | " + response);
                return RedirectToAction("FormADetails", new { applicationId = applicationId });
            }
            catch (Exception ex)
            {
                string innerMessage = ex.InnerException.Message;

                if (int.TryParse(innerMessage, out int statusCode))
                {
                    object responseModel = ex.InnerException.InnerException.Message.ToString();
                    _notyf.Error(statusCode + " | " + responseModel);
                }
                else
                {
                    _notyf.Error(500 + " | " + ex.InnerException.Message);
                }
            }
            return RedirectToAction("FormADetails", new { applicationId = applicationId });
        }

        public IActionResult FormNCXDetails(string applicationId)
        {
            //var token = _tokenStorageService.RetrieveToken();
            FormNCXDetailsPageDTO details = new FormNCXDetailsPageDTO();
            //details = _formADetailsRepository.GetFormADetails(applicationId, token).Result; // Replace with your actual details retrieval logic
            return View(details); // Assuming _Details.cshtml is your details view
        }

        [HttpPost]
        public IActionResult ApproveFormNCX(ADBReviewerRequestNCX adbreviewerncx, string applicationId)
        {
            try
            {
                string response = "";
                //var token = _tokenStorageService.RetrieveToken();
                if (adbreviewerncx.Approved == true)
                {
                    response = _adbReviewerNCXRepository.ADBReviewerNCX(adbreviewerncx, applicationId, "ghvghvghn").Result.ResponseResult;
                }
                else
                {
                    response = _cancelADBReviewerNCXRepository.CancelADBReviewerNCX(adbreviewerncx, applicationId, "ghvghvghn").Result.ResponseResult;
                }
                _notyf.Success("Fintrak | " + response);
                return RedirectToAction("FormADetails", new { applicationId = applicationId });
            }
            catch (Exception ex)
            {
                string innerMessage = ex.InnerException.Message;

                if (int.TryParse(innerMessage, out int statusCode))
                {
                    object responseModel = ex.InnerException.InnerException.Message.ToString();
                    _notyf.Error(statusCode + " | " + responseModel);
                }
                else
                {
                    _notyf.Error(500 + " | " + ex.InnerException.Message);
                }
            }
            return RedirectToAction("FormADetails", new { applicationId = applicationId });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}