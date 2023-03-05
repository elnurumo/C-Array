const finKodlar = ['7qcnd8a', 'j6k9a5s', 'x8p2m4t'];
const regex = /^[a-z0-9]{7}$/i;

while (true) {
  const finKod = prompt("FinKod daxil edin:");
  if (finKod == null) { // Əgər cancel butonuna basılarsa layihə dayandırılır
     console.log("Ləğv edildi");
     break;
  }
  else if (regex.test(finKod)) { // format düzgündür
    const index = finKodlar.indexOf(finKod);
    if (index === -1) { // array-də yoxdur
      alert('FinKod tapılmadı!');
    } else { // array-də var
      alert('User tapıldı!');
      console.log(`FinKodun indeksi: ${index}`);
      break;
    }
  } else { // format yalnışdır
    alert('Yanlış format!');
  }
}


