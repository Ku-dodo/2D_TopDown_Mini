## 구현된 내용
### 캐릭터 선택 및 닉네임 변경
___
<img width = "70%" src="https://private-user-images.githubusercontent.com/105593231/286461800-6f2c3e53-66d8-454e-900a-c801a7cad63a.gif?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTEiLCJleHAiOjE3MDEyMjczNzYsIm5iZiI6MTcwMTIyNzA3NiwicGF0aCI6Ii8xMDU1OTMyMzEvMjg2NDYxODAwLTZmMmMzZTUzLTY2ZDgtNDU0ZS05MDBhLWM4MDFhN2NhZDYzYS5naWY_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBSVdOSllBWDRDU1ZFSDUzQSUyRjIwMjMxMTI5JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDIzMTEyOVQwMzA0MzZaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT0xOWYxYThhMWQ5MzhlZDA0ZTk2NmJlYmUwODNkYjcxYzY5YzhmMTdjYjUwNTFhMzVkZjUxYmRjZGMzNDRkNjg0JlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCZhY3Rvcl9pZD0wJmtleV9pZD0wJnJlcG9faWQ9MCJ9.gkvUS9x6JbUc4ofCHz7xCJqJH5cBmrVzUTN5-MOk5m0" alt="Character Select" />
  캐릭터 선택 : 캐릭터 선택 시 해당 캐릭터는 애니메이션이 활성화되며 나머지는 애니메이션이 정지됩니다.
  <br/>
  <br/>
<img width = "70%" src="https://private-user-images.githubusercontent.com/105593231/286461897-b958bd0f-2d1c-4cf0-babf-081e01922650.gif?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTEiLCJleHAiOjE3MDEyMjczNzYsIm5iZiI6MTcwMTIyNzA3NiwicGF0aCI6Ii8xMDU1OTMyMzEvMjg2NDYxODk3LWI5NThiZDBmLTJkMWMtNGNmMC1iYWJmLTA4MWUwMTkyMjY1MC5naWY_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBSVdOSllBWDRDU1ZFSDUzQSUyRjIwMjMxMTI5JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDIzMTEyOVQwMzA0MzZaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT1kYmQ0ZjE2ZmFjOGQxNmI4NDY4NGQ3Njc2ZjBhYzI0ZDU2NDNmZTVkMDY2NzkxNjUxYzM4N2M3Njg3YzVhZDkyJlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCZhY3Rvcl9pZD0wJmtleV9pZD0wJnJlcG9faWQ9MCJ9.CHCnp2tq1uzzOuDacYSV2ze9f5OHghYOawjtFgwjSXU" alt="NickName Setting"/>
  닉네임 설정
  : 5글자 이상 닉네임 설정이 가능합니다.

### 캐릭터 정보 변경
___
<img width = "70%" src="https://private-user-images.githubusercontent.com/105593231/286462444-e43dabd3-38e1-4178-9af8-103cd2864caa.gif?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTEiLCJleHAiOjE3MDEyMjc1NjksIm5iZiI6MTcwMTIyNzI2OSwicGF0aCI6Ii8xMDU1OTMyMzEvMjg2NDYyNDQ0LWU0M2RhYmQzLTM4ZTEtNDE3OC05YWY4LTEwM2NkMjg2NGNhYS5naWY_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBSVdOSllBWDRDU1ZFSDUzQSUyRjIwMjMxMTI5JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDIzMTEyOVQwMzA3NDlaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT1lNDFiNzY1ZTI5ZmRlYjdkMzQ0MDQzMzcyYWIxZjM2MTI2NDY0N2ZjMjMzNDk2ZWVkMjgyNGQ1NThlNjY5ODU2JlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCZhY3Rvcl9pZD0wJmtleV9pZD0wJnJlcG9faWQ9MCJ9.aALL8ppKprIcHMN5Yo5DJ-JFZ9voybVXONCw4_KhUmQ" alt="NickName Setting"/>

  캐릭터 설정 창 열기 / 닫기 
  : 우측 상단 메뉴 버튼을 클릭하면 캐릭터 설정 창이 열리며, 저장하기를 누르면 조건을 확인한 후 닫힙니다.<br/>이때 마우스 및 키보드 조작은 제한됩니다.


### 캐릭터 및 카메라 이동
___
<img width = "70%" src="https://private-user-images.githubusercontent.com/105593231/286462366-4bbbafc7-d386-48f4-8d7d-942f4a49a5d6.gif?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTEiLCJleHAiOjE3MDEyMjc1NjksIm5iZiI6MTcwMTIyNzI2OSwicGF0aCI6Ii8xMDU1OTMyMzEvMjg2NDYyMzY2LTRiYmJhZmM3LWQzODYtNDhmNC04ZDdkLTk0MmY0YTQ5YTVkNi5naWY_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBSVdOSllBWDRDU1ZFSDUzQSUyRjIwMjMxMTI5JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDIzMTEyOVQwMzA3NDlaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT03ODI2MWI5MTgyMzNjZDA0MjZiNzY3M2ZkNTY2NzA2ZGFmZmViMDVkNDY4Nzg0Yzc5ZGIwOTRkN2QyMzY3NWMwJlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCZhY3Rvcl9pZD0wJmtleV9pZD0wJnJlcG9faWQ9MCJ9.dBVgBICO78sMqUKlpKdIyZJq1lleLPRBkYuPf1DyOHU" alt="Camera Move"/>
  카메라 이동
  : 기본적으로 캐릭터를 따라가며, 캐릭터 기준 마우스 방향에 더 넓은 시야를 갖습니다.
  <br/>
  <br/>
<img width = "70%" src="https://private-user-images.githubusercontent.com/105593231/286461168-f61a06fa-5da1-48c6-b3e8-509a4cce2053.gif?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTEiLCJleHAiOjE3MDEyMjc1NjksIm5iZiI6MTcwMTIyNzI2OSwicGF0aCI6Ii8xMDU1OTMyMzEvMjg2NDYxMTY4LWY2MWEwNmZhLTVkYTEtNDhjNi1iM2U4LTUwOWE0Y2NlMjA1My5naWY_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBSVdOSllBWDRDU1ZFSDUzQSUyRjIwMjMxMTI5JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDIzMTEyOVQwMzA3NDlaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT05ZGFhMjQzNDY4NTFmOTJlYWJhZTU0YmYyOGIzYmE4NmYzYTc1MTJhY2Y0OWMyZTAzOWMxYjZmZWVkYjMxMmJhJlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCZhY3Rvcl9pZD0wJmtleV9pZD0wJnJlcG9faWQ9MCJ9.2nlVoTQCggRzEyY5NXeyibyFnZmS1aNbUqgW-EdAVuQ" alt="Camera Move"/>
  캐릭터 이동
  : W, A, S, D를 통해 캐릭터를 이동 시킬 수 있습니다.
