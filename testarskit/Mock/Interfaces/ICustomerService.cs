using testarskit.Mock.Entities;

namespace testarskit.Mock.Interfaces;

public interface ICustomerService
{
    InquiryResponse ReceiveCustomerInquiry(CustomerInquiry inquiry);
    void RespondToInquiry(InquiryResponse response);
}