public class TimeMap {
    Dictionary<string,Dictionary<int,string>> map;

    public TimeMap() {
        map=new();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!map.ContainsKey(key)){
            map[key]=new Dictionary<int,string>();
        }
        var newPair=map[key];
        newPair.Add(timestamp,value);
    }
    
    public string Get(string key, int timestamp) {
        if(!map.ContainsKey(key))
        return "";
        while(timestamp>=1 &&!map[key].ContainsKey(timestamp)){
            timestamp--;
        }
        if(timestamp==0) return "";
        var newPair=map[key];
        return newPair[timestamp];
    }
}
