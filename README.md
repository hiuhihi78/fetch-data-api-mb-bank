# fetch-data-api-mb-bank

This repository it help get data of api MB bank includes:
+ Get history transaction
+ Inquiry account name
+ ...

## Infomation
![list-api](https://github.com/hiuhihi78/fetch-data-api-mb-bank/assets/85660078/e6f9d213-df2e-4854-93e6-4cd3385ccfdd)

This application inclues 4 api: 
- [GET] /api/MbBanks/HistoryTransaction
- [POST] /api/MbBanks/HistoryTransaction
- [GET] /api/MbBanks/InquiryAccountName
- [POST] /api/MbBanks/InquiryAccountName

## Configuration
- Step 1: Login your Mb Bank account to get seessionId [click here!](https://online.mbbank.com.vn/pl/login)
- Step 2: Chose [Thông tin tài khoản][Tài khoản nguồn]
- Step 3: Open Developer Tools[F12] -> Chose Network
- Step 4: Click into [Truy vấn]
  After that you can see
![f12](https://github.com/hiuhihi78/fetch-data-api-mb-bank/assets/85660078/edadcb7f-9261-4d1e-92d4-47eb316fc8bd)
- Step 5: Open project and open appsetting.cs file
![appsettings](https://github.com/hiuhihi78/fetch-data-api-mb-bank/assets/85660078/5a12e218-0059-40e1-bfb8-40a2c045515f)
- Step 6: Copy and paste some fields in step 5 into appsettings.cs file <br />
  [AccountNo]<br />
  [DeviceIdCommon]<br />
  [RefNo]<br />
  [SessionId]<br />

## Usage
### [GET] /api/MbBanks/HistoryTransaction
#### URL Parameter
- fromDate: Start date (dd/MM/yyyy)
- toDate: End date (dd/MM/yyyy)
