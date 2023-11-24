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
    [Authorize(AuthenticationSchemes = "ExternalApiBearer")]
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
        IPendingNXPShipmentRepository _pendingNXPShipmentRepository;
        IApprovalRejectionRepository _approvalRejectionRepository;
        IDisbursementReviewerRepository _disbursementReviewerRepository;
        IADBReviewerRepository _adbReviewerRepository;
        IADBReviewerNCXRepository _adbReviewerNCXRepository;
        ICancelADBReviewerNCXRepository _cancelADBReviewerNCXRepository;
        IFormNCXDetailsRepository _formNCXDetailsRepository;

        public HomeController(ILogger<HomeController> logger, IPendingApplicationRepository pendingApplicationRepository,
            IProcessedApplicationRepository processedApplicationRepository, IFormADetailsRepository formADetailsRepository, 
            TokenStorageService tokenStorageService, IProcessedApplicationNCXRepository processedApplicationNCXRepository,
            IPendingApplicationNCXRepository pendingApplicationNCXRepository, IPendingFormNXPRepository pendingFormNXPRepository,
            IProcessedNXPRepository processedNXPRepository, INXPFormDetailsRepository nXPFormDetailsRepository,
            ISingleShipmentRepository singleShipmentRepository, IShipmentFormDetailsRepository shipmentFormDetailsRepository,
            IPendingNXPShipmentRepository pendingNXPShipmentRepository, INotyfService notyf, IApprovalRejectionRepository approvalRejectionRepository,
            IDisbursementReviewerRepository disbursementReviewerRepository, IADBReviewerRepository adbReviewerRepository,
            IADBReviewerNCXRepository adbReviewerNCXRepository, ICancelADBReviewerNCXRepository cancelADBReviewerNCXRepository,
            IFormNCXDetailsRepository formNCXDetailsRepository)
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
            _pendingNXPShipmentRepository = pendingNXPShipmentRepository;
            _notyf = notyf;
            _approvalRejectionRepository = approvalRejectionRepository;
            _disbursementReviewerRepository = disbursementReviewerRepository;
            _adbReviewerRepository = adbReviewerRepository;
            _adbReviewerNCXRepository = adbReviewerNCXRepository;
            _cancelADBReviewerNCXRepository = cancelADBReviewerNCXRepository;
            _formNCXDetailsRepository = formNCXDetailsRepository;
        }

        public IActionResult Index(string applicationId = "")
        {
            FormAPageDTO formAPageDTO = new FormAPageDTO();
            try
            {
                var token = _tokenStorageService.RetrieveToken();
                formAPageDTO.PendingFormA = _pendingApplicationRepository.PendingApplication(applicationId, token).Result;
                formAPageDTO.ProcessedFormA = _processedApplicationRepository.ProcessedApplication(applicationId, token).Result;
                return View(formAPageDTO);
            }
            catch (Exception ex)
            {
                string innerMessage = ex.InnerException.Message;

                if (int.TryParse(innerMessage, out int statusCode))
                {
                    object responseModel = ex.InnerException.InnerException.Message.ToString();
                    _notyf.Error(statusCode + " | " + responseModel); 
                    return View(formAPageDTO);
                }
                else
                {
                    _notyf.Error(500 + " | " + ex.InnerException.Message);
                    return View(formAPageDTO);
                }
            }
        }

        public IActionResult FormNCX(string applicationId = "")
        {
            FormNCXPageDTO formNCXPageDTO = new FormNCXPageDTO();
            try
            {
                var token = _tokenStorageService.RetrieveToken();
                formNCXPageDTO.PendingFormNCX = _pendingApplicationNCXRepository.PendingApplicationNCX(applicationId, token).Result;
                formNCXPageDTO.ProcessedFormNCX = _processedApplicationNCXRepository.ProcessedApplicationNCX(applicationId, token).Result;
                return View(formNCXPageDTO);
            }
            catch (Exception ex)
            {
                string innerMessage = ex.InnerException.Message;

                if (int.TryParse(innerMessage, out int statusCode))
                {
                    object responseModel = ex.InnerException.InnerException.Message.ToString();
                    _notyf.Error(statusCode + " | " + responseModel);
                    return View(formNCXPageDTO);
                }
                else
                {
                    _notyf.Error(500 + " | " + ex.InnerException.Message);
                    return View(formNCXPageDTO);
                }
            }
        }

        public IActionResult FormNXP(string applicationId = "")
        {
            FormNXPPageDTO formNXPPageDTO = new FormNXPPageDTO();
            try
            {
                var token = _tokenStorageService.RetrieveToken();
                formNXPPageDTO.PendingFormNXP = _pendingFormNXPRepository.GetPendingFormNXP(applicationId, token).Result;
                formNXPPageDTO.ProcessedFormNXP = _processedNXPRepository.GetProcessedNXP(applicationId, token).Result;

                //formNXPPageDTO.FormNXPDetail = _nXPFormDetailsRepository.GetNXPFormDetails(applicationId, token).Result;
                //formNXPPageDTO.NXPShipments = _singleShipmentRepository.GetSingleShipment(applicationId, token).Result;
                formNXPPageDTO.PendingNXPShipments = _pendingNXPShipmentRepository.GetPendingNXPShipment(applicationId, token).Result;
                //formNXPPageDTO.ShipmentFormDetail = _shipmentFormDetailsRepository.GetShipmentFormDetails(applicationId, token).Result;
                return View(formNXPPageDTO);
            }
            catch (Exception ex)
            {
                string innerMessage = ex.InnerException.Message;

                if (int.TryParse(innerMessage, out int statusCode))
                {
                    object responseModel = ex.InnerException.InnerException.Message.ToString();
                    _notyf.Error(statusCode + " | " + responseModel);
                    return View(formNXPPageDTO);
                }
                else
                {
                    _notyf.Error(500 + " | " + ex.InnerException.Message);
                    return View(formNXPPageDTO);
                }
            }
        }

        public IActionResult FormNXPDetails(string applicationId)
        {
            FormNXPPageDTO formNXPPageDTO = new FormNXPPageDTO();
            try
            {
                var token = _tokenStorageService.RetrieveToken();
                formNXPPageDTO.FormNXPDetail = _nXPFormDetailsRepository.GetNXPFormDetails(applicationId, token).Result;
                formNXPPageDTO.ShipmentFormDetail = _shipmentFormDetailsRepository.GetShipmentFormDetails(applicationId, token).Result; // Replace with your actual details retrieval logic
                return View(formNXPPageDTO); // Assuming _Details.cshtml is your details view
            }
            catch (Exception ex)
            {
                string innerMessage = ex.InnerException.Message;

                if (int.TryParse(innerMessage, out int statusCode))
                {
                    object responseModel = ex.InnerException.InnerException.Message.ToString();
                    _notyf.Error(statusCode + " | " + responseModel); 
                    return RedirectToAction("FormNXP", "Home");
                }
                else
                {
                    _notyf.Error(500 + " | " + ex.InnerException.Message);
                    return RedirectToAction("FormNXP", "Home");
                }
            }
        }

        public IActionResult FormADetails(string applicationId = "")
        {
            FormADetailsPageDTO details = new FormADetailsPageDTO();
            try
            {
                var token = _tokenStorageService.RetrieveToken();
                details.FormADetails = _formADetailsRepository.GetFormADetails(applicationId, token).Result; // Replace with your actual details retrieval logic
                return View(details); // Assuming _Details.cshtml is your details view
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
                    object responseModel = ex.InnerException.Message.ToString();
                    _notyf.Error(500 + " | " + responseModel);
                }
            }
            return View(details);
        }

        [HttpPost]
        public IActionResult ApprovalFormA(ApprovalRejectionRequest approvalFormA, string applicationId, string adb)
        {
            try
            {
                string response = "";
                var token = _tokenStorageService.RetrieveToken();
                if (adb == "false")
                {
                    response = _approvalRejectionRepository.ApprovalRejection(approvalFormA, applicationId, token).Result.ResponseResult;
                }
                else
                {
                    ADBReviewerRequest cancelRequest = new ADBReviewerRequest();
                    cancelRequest.Approved = approvalFormA.Approved;
                    cancelRequest.DaemonReviewName = approvalFormA.DaemonReviewerName;
                    cancelRequest.Note = approvalFormA.Note;
                    cancelRequest.RejectionReasonCode = approvalFormA.RejectionReasonCode;
                    cancelRequest.DaemonSupervisorName = approvalFormA.DaemonSupervisorName;
                    response = _adbReviewerRepository.ADBReviewer(cancelRequest, applicationId, token).Result.responseMessage;
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
                var token = _tokenStorageService.RetrieveToken();
                if (disbursement.RejectionStakeholder == "Approved")
                {
                    disbursement.Approved = true;
                    disbursement.RejectionStakeholder = null;
                    response = _disbursementReviewerRepository.DisbursementReviewer(disbursement, applicationId, token).Result.ResponseResult;
                }
                else
                {
                    RejectDisbursementRequest rejectDisbursement = new RejectDisbursementRequest();
                    rejectDisbursement.Note = disbursement.Note;
                    rejectDisbursement.DisbursementsCloseOut = true;
                    rejectDisbursement.RejectionStakeholder = disbursement.RejectionStakeholder;
                    rejectDisbursement.RejectionReasonCode = reasonCode;
                    response = _disbursementReviewerRepository.RejectDisbursement(rejectDisbursement, applicationId, token).Result.ResponseResult;
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

            FormNCXDetailsPageDTO details = new FormNCXDetailsPageDTO();
            try
            {
                var token = _tokenStorageService.RetrieveToken();
                details.FormNCXDetails = _formNCXDetailsRepository.GetFormNCXDetails(applicationId, token).Result; // Replace with your actual details retrieval logic
                return View(details);
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
                    object responseModel = ex.InnerException.Message.ToString();
                    _notyf.Error(500 + " | " + responseModel);
                }
            }
            return View(details);
        }

        [HttpPost]
        public IActionResult ApproveFormNCX(ADBReviewerRequestNCX adbreviewerncx, string applicationId, string adb)
        {
            try
            {
                ADBReviewerResponse response = new ADBReviewerResponse();
                var token = _tokenStorageService.RetrieveToken();
                if (adb == "false")
                {
                    response = _adbReviewerNCXRepository.ADBReviewerNCX(adbreviewerncx, applicationId, token).Result;
                }
                else
                {
                    response = _cancelADBReviewerNCXRepository.CancelADBReviewerNCX(adbreviewerncx, applicationId, token).Result;
                }
                _notyf.Success("Fintrak | " + response);
                return RedirectToAction("FormNCXDetails", new { applicationId = applicationId });
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
            return RedirectToAction("FormNCXDetails", new { applicationId = applicationId });
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
