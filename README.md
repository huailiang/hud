<p align="center">
	 <a href="https://huailiang.github.io/">
	    <img src="https://huailiang.github.io/img/cpp.jpeg" width="100" height="100">
     </a>
</p>

目前unity里UI实现一般都是通过NGUI或者uGUI。

往往使用这些的UI的时候，会带来两个缺陷：

1. 由于层级交错带来DrawCall的升高，带来的问题就是性能的降低。

2. 血条往往是动态的，但这些动态的东西往往会触发Lateupdate的Rebuild,从来带来一帧较大的开销，容易触发gc



这里介绍的方法是通过3D mesh的方式绘制血条，所有的HUD能够动态batch合批, 只有2个drawcall的开销。


实现方式：

动态创建Mesh， Shader里采样顶点色来最终血条。

字体也不再使用2d UI的Text或者UILable这样的是空间，而是3D TextMesh.



此项目采用Unity的版本Unity2017.3f1