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
