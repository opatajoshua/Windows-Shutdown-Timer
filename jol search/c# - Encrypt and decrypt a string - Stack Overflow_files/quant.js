/* Copyright (c) 2008-2013, Quantcast Corp. */
if(!__qc){var __qc={qs:'quantserve.com',ql:'quantcount.com',pixelcalls:[],pmto:null,pmc:undefined,qcdst:function(){if(__qc.qctzoff(0)!=__qc.qctzoff(6))return 1;return 0;},qctzoff:function(m){var d1=new Date(2000,m,1,0,0,0,0);var t=d1.toGMTString();var d3=new Date(t.substring(0,t.lastIndexOf(" ")-1));return d1-d3;},qceuc:function(s){if(typeof(encodeURIComponent)=='function'){return encodeURIComponent(s);}
else{return escape(s);}},qcrnd:function(){return Math.round(Math.random()*2147483647);},qcgc:function(n){var v='';var c=document.cookie;if(!c)return v;var i=c.indexOf(n+"=");var len=i+n.length+1;if(i>-1){var end=c.indexOf(";",len);if(end<0)end=c.length;v=c.substring(len,end);}
return v;},qcdomain:function(){var d=document.domain;if(d.substring(0,4)=="www.")d=d.substring(4,d.length);var a=d.split(".");var len=a.length;if(len<3)return d;var e=a[len-1];if(e.length<3)return d;d=a[len-2]+"."+a[len-1];return d;},qhash2:function(h,s){for(var i=0;i<s.length;i++){h^=s.charCodeAt(i);h+=(h<<1)+(h<<4)+(h<<7)+(h<<8)+(h<<24);}
return h;},qhash:function(s){var h1=0x811c9dc5,h2=0xc9dc5118;var hash1=__qc.qhash2(h1,s);var hash2=__qc.qhash2(h2,s);return(Math.round(Math.abs(hash1*hash2)/65536)).toString(16);},sd:["4dcfa7079941","127fdf7967f31","588ab9292a3f","32f92b0727e5","22f9aa38dfd3","a4abfe8f3e04","18b66bc1325c","958e70ea2f28","bdbf0cb4bbb","65118a0d557","40a1d9db1864","18ae3d985046","3b26460f55d"],qcsc:function(){var s="";var d=__qc.qcdomain();if(__qc.qad==1)return";fpan=u;fpa=";var qh=__qc.qhash(d);for(var i=0;i<__qc.sd.length;i++){if(__qc.sd[i]==qh)return";fpan=u;fpa=";}
var u=document;var a=__qc.qcgc("__qca");if(a.length>0){s+=";fpan=0;fpa="+a;}
else{var da=new Date();var db=new Date(da.getTime()+47335389000);a='P0-'+__qc.qcrnd()+'-'+da.getTime();u.cookie="__qca="+a+"; expires="+db.toGMTString()+"; path=/; domain="+d;a=__qc.qcgc("__qca");if(a.length>0){s+=";fpan=1;fpa="+a;}
else{s+=";fpan=u;fpa=";}}
return s;},qcdc:function(n){document.cookie=n+"=; expires=Thu, 01 Jan 1970 00:00:01 GMT; path=/; domain="+__qc.qcdomain();},qpxload:function(img){if(img&&typeof(img.width)=="number"&&img.width==3){__qc.qcdc("__qca");}},qcdnt:function(){var ipf=false;if(typeof(window.external)!=='undefined'&&window.external!==null){var we=window.external;ipf=(typeof we.InPrivateFilteringEnabled==='function'&&we.InPrivateFilteringEnabled()===true);}
return(ipf||navigator.doNotTrack==="1"||navigator.doNotTrack==="yes"||navigator.msDoNotTrack==="1");},qcp:function(p,myqo){var s='',a=null;uh=null;var media='webpage',event='load';if(myqo!=null){for(var k in myqo){if(typeof(k)!='string'){continue;}
if(typeof(myqo[k])!='string'){continue;}
if(k=='uid'||k=='uh'){if(__qc.qcdnt()===false){uh=__qc.qhash(myqo[k]);}
delete myqo[k];continue;}
if(k=='qacct'){a=myqo[k];continue;}
s+=';'+k+p+'='+__qc.qceuc(myqo[k]);if(k=='media'){media=myqo[k];}
if(k=='event'){event=myqo[k];}}}
if(typeof a!="string"){if((typeof _qacct=="undefined")||(_qacct.length==0))return'';a=_qacct;}
if(typeof uh===