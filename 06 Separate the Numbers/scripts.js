
function IsBeautiful(arr) {
  if (arr.length == 0)
    return false;

  for(var i = 0; i < (arr.length + 1)/2; i++)
  {
    if ((arr[i] < "0") || (arr[i] > "9"))
      return false;

    var number = ParseInt(arr[0:i]);
    var beautifulString = arr[0:i];

    number++;
    beautifulString += number.toString();

    while((beautifulString.length != arr.length) && (arr.substring(0, beautifulString.length) === beautifulString)){
      number++;
      beautifulString += number.toString();
    }
    if (beautifulString == arr)
      return true;
  }
  return false;
}
