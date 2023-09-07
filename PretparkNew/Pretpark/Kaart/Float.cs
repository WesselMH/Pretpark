namespace Pretpark;

static class Float
{
    public static String metSuffixen(this float f){
        if(f>=1000 && f<1000000)
        {
            f /= 1000;
            return string.Format("{0:0.0}K", f);
        }
        if(f>=1000000 && f<1000000000){
            f /= 1000000;
            return string.Format("{0:0.0}M", f);
        }
        if(f>=1000000000 && f<1000000000000){
            f /= 1000000000;
            return string.Format("{0:0.0}B", f);
        }
        return "" + f;
    }    
}