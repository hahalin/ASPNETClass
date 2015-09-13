---
layout: page
title: 歡迎來到ASP.NET教室!
tagline: 以MVC為主，適用初學者
---
{% include JB/setup %}

##簡述

會建置這個網站的緣起是想把這陣子的教學內容給系統化的整理系統，讓之後有興趣的朋友可以有個參考，並藉此整合使用了[GitHub](https://github.com)、GitPage以及[Jekyll](https://github.com/jekyll/jekyll)。

課程內容以ASP.NET+MVC為主，搭配教學上課時建置的範例專案放置在Github上，讓閱讀這些教學內容時也能透過GitHub下載來自行修改練習，從做中學。

##文章清單

<ul class="posts">
  {% for post in site.posts %}
    <li><span>{{ post.date | date_to_string }}</span> &raquo; <a href="{{ ASSET_PATH }}{{ post.url }}">{{ post.title }}</a></li>
  {% endfor %}
</ul>




