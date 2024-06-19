# 📃 Random Person Info GET API
Small API for generating random user data.

## ▶️ How to Run
1. Execute the script from [Database.sql](https://github.com/spacebagel/RandomDudeAPI/blob/master/Database.sql) in MSSQL.
2. Change `"ConnectionString": ""` in the appsettings.json file.

![ConnectionString](https://github.com/spacebagel/RandomDudeAPI/assets/165411846/031f83ba-cc81-443e-8362-08a487175359)

3. (optional) Install and use HttpRepl

```powershell
dotnet tool install -g Microsoft.dotnet-httprepl
```
```powershell
dotnet run --urls=https://localhost:PORT
```
## 🎊 Examples
```json
[
  {
    "lastName": "Нечаев",
    "firstName": "Клим",
    "middleName": "Порфириевич",
    "gender": "Мужской",
    "birthdate": "27.08.1957",
    "phoneNumber": "+79564001617",
    "email": "nechaev_9512@bk.ru",
    "adress": {
      "city": "Нахичевань",
      "region": "Калмыкия",
      "country": "Россия"
    }
  },
  {
    "lastName": "Гончаров",
    "firstName": "Климентий",
    "middleName": "Станиславович",
    "gender": "Мужской",
    "birthdate": "18.01.1945",
    "phoneNumber": "+79514198048",
    "email": "goncharov51@ya.ru",
    "adress": {
      "city": "Джеймстаун",
      "region": "Bistrita-Nasaud",
      "country": "Румыния"
    }
  },
  {
    "lastName": "Акимов",
    "firstName": "Фадей",
    "middleName": "Андрониевич",
    "gender": "Мужской",
    "birthdate": "30.04.1989",
    "phoneNumber": "+79754639074",
    "email": "akimov_4199@outlook.com",
    "adress": {
      "city": "Baexem",
      "region": "Нарынская обл.",
      "country": "Кыргызстан"
    }
  }
]
```
