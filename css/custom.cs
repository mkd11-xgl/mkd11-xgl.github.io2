/* 企业定制样式 - 通过覆盖方式实现 */

/* 品牌色 */
:root {
  --primary-blue: #2A5C8A;
  --accent-gold: #C9A769;
}

/* 导航栏调整 */
.tm-navbar {
  background: rgba(255,255,255,0.98)!important;
  box-shadow: 0 2px 10px rgba(0,0,0,0.1);
}
.navbar-brand {
  font-size: 1.4rem;
  font-weight: 600;
}

/* 产品图标增强 */
.tm-icon {
  color: var(--primary-blue);
  transition: transform 0.3s;
}
.tm-icon:hover {
  transform: scale(1.2);
}

/* 联系信息样式 */
.contact-info h4 {
  color: var(--primary-blue);
  font-size: 1.2rem;
  margin-bottom: 0.5rem;
}
.contact-info i {
  margin-right: 10px;
  color: var(--accent-gold);
}

/* 表单样式覆盖 */
.tm-btn-primary {
  background: var(--primary-blue);
  border: none;
  padding: 12px 40px;
}
.tm-btn-primary:hover {
  background: var(--accent-gold);
}
/* ---- 你的其他 CSS 样式 ---- */

/* ------- 下面是你加的按钮样式 ------- */
@media (max-width: 768px) {
  .btn-next, .btn-prev {
    background-color: #007bff;
    color: white;
    border-radius: 50px;
    padding: 10px 20px;
    border: none;
    transition: background-color 0.3s, box-shadow 0.3s;
  }

  .btn-next:hover, .btn-prev:hover {
    background-color: #0056b3;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2);
  }
}

