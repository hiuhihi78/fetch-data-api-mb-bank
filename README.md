# Fetch data api Mb bank

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
![f12](https://github.com/hiuhihi78/fetch-data-api-mb-bank/assets/85660078/6ee0e42a-283a-42b0-bf83-32f142d43499)
- Step 5: Open project and open appsetting.cs file
![appsettings](https://github.com/hiuhihi78/fetch-data-api-mb-bank/assets/85660078/78453256-fa44-4dd4-833d-4e67e37811cc)
- Step 6: Copy and paste some fields in step 4 into appsettings.cs file <br />
  [AccountNo]<br />
  [DeviceIdCommon]<br />
  [RefNo]<br />
  [SessionId]<br />

## Usage

#### [GET] /api/MbBanks/HistoryTransaction
##### URL Parameter
- "fromDate": "string" (dd/MM/yyyy)
- "toDate": "string" (dd/MM/yyyy)
#### Sample
![simple-1](https://github.com/hiuhihi78/fetch-data-api-mb-bank/assets/85660078/00fc791c-0bb9-401a-8543-6ba3f3e0d5a8)

<hr/>

#### [POST] /api/MbBanks/HistoryTransaction
##### Request Body
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

#### [GET] /api/MbBanks/InquiryAccountName
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

##### URL Parameter
- "bankCode": "string" 
- "creditAccount": "string" (Account number)

<hr/>

#### [POST] /api/MbBanks/InquiryAccountName
##### Request Body
```json
{
  "bankCode": "string",
  "creditAccount": "string",
  "creditAccountType": "string",
  "debitAccount": "string",
  "deviceIdCommon": "string",
  "refNo": "string",
  "remark": "string",
  "sessionId": "string",
  "type": "string"
}
```

### More api can make in future
![fu](https://github.com/hiuhihi78/fetch-data-api-mb-bank/assets/85660078/afdf8cdf-f375-4850-968d-6cd9fefc125d)


## &copy; 2023 - hiuhihi78 - A student from FPT University

