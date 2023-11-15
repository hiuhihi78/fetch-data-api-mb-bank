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
- "fromDate": "string" (dd/MM/yyyy)
- "toDate": "string" (dd/MM/yyyy)
### Sample
![simple-1](https://github.com/hiuhihi78/fetch-data-api-mb-bank/assets/85660078/00fc791c-0bb9-401a-8543-6ba3f3e0d5a8)

<hr/>

### [POST] /api/MbBanks/HistoryTransaction
#### Request Body
```json
{
  "accountNo": "string",
  "deviceIdCommon": "string",
  "fromDate": "string",
  "refNo": "string",
  "sessionId": "string",
  "toDate": "string"
}
```

<hr/>

### [GET] /api/MbBanks/InquiryAccountName
This api to search account name by bank code and account bank number

| Bank  | BankCode |
| ------------- | ------------- |
| TNHH MTV HSBC Việt Nam (HSBC)  | 458761  |
| Sacombank (STB)  | 970403  |
| Nông nghiệp và Phát triển nông thôn (VBA)  | 970405  |
| Kỹ Thương (TCB)  | 970407  |
| Công Thương Việt Nam (VIETINBANK)  | 970415  |
| Đầu tư và phát triển (BIDV)  | 970418  |
| Quân đội (MB)  | 970422  |
| Tiên Phong (TPB)  | 970423  |
| Hàng hải (MSB)  | 970426  |
| Việt Nam Thinh Vượng (VPB)  | 970432  |
| Ngoại thương Việt Nam (VCB)  | 970436  |
| Quốc tế (VIB) | 970441  |
| Sài Gòn Hà Nội (SHB)  | 970443  |
| Bưu điện Liên Việt (LPB)  | 970449  |

#### URL Parameter



