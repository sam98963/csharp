public class Kata_004 { 
  public static int evaporator(double content, double evap_per_day, double threshold) {
    int day = 0;
    double current = content;
    while((current / content) > (threshold/100)){
      current *= 1-(evap_per_day/100);
      day++;
    }
    return day;
  }
}