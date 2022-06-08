function Convert() {
  var url =
    "https://api.apilayer.com/currency_data/convert?to=GBP&from=USD&amount=100";

  var xhr = new XMLHttpRequest();
  xhr.open("GET", url);

  xhr.setRequestHeader("apikey", "uQvrOvY98Px1fsgLmvDtkCSEOtYtWpLK");

  xhr.onreadystatechange = function () {
    if (xhr.readyState === 4) {
      console.log(xhr.status);
      console.log(xhr.responseText);
    }
  };

  xhr.send();
}

function List() {
  const List = fetch("JS/currencies.json");

  console.log(
    List.then((List) => List.json()).then((List) => console.log(List[10]))
  );
}

List();
