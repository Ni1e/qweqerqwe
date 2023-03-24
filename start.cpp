#include <iostream> 
using namespace std;
int main() 
{ 
    int h, m, s;
    cin >> h >> m >> s; 
    int h2, m2, s2; 
    cin >> h2 >> m2 >> s2; 
    int res,res2,result; 
    int resh, resm,ress; 
    res = h * 3600 + m * 60 + s; 
    res2 = h2 * 3600 + m2 * 60 + s2; 
    result  =res2 - res; 
    cout << result; 
    resh = result / 3600; 
    resm = (result - resh * 3600) / 60; 
    ress = result - resh * 3600 - resm * 60; 
    cout << resh << resm << ress; 
    return 0; 
     
}